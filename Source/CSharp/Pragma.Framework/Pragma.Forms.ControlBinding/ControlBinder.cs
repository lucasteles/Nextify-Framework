using Pragma.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reactive.Linq;
using System.Windows.Forms;

namespace Pragma.ModelViewBinder
{
    public class ModelViewBinder<TModel> : IModelViewBinder<TModel>, IModelViewBinderWithCallback<TModel>
    {
        private TModel Model;
        private readonly IList<IDisposable> BindersToDispose = new List<IDisposable>();
        public IList<IRegisterItem<TModel>> Controls { get; set; } = new List<IRegisterItem<TModel>>();
        protected IRegisterItem<TModel> LastRegister { get; set; }
        public ModelViewBinder()
        {
        }
        public IModelViewBinder<TModel> SetModel(TModel model)
        {
            Model = model;

            return this;
        }

        public IModelViewBinderWithCallback<TModel> Register<TControl>(Expression<Func<TModel, object>> expression, TControl control) where TControl : class, IControlWithValue
        {
            var register = new RegisterItem<TModel, object, TControl>(expression, control, e => e.Value);

            Add(register);

            return this;
        }

        public IModelViewBinderWithCallback<TModel> Register<TPropertie, TControl>(Expression<Func<TModel, TPropertie>> expression, TControl control, Expression<Func<TControl, TPropertie>> controlExpression)
             where TControl : class
        {
            var register = new RegisterItem<TModel, TPropertie, TControl>(expression, control, controlExpression, null);
            Add(register);

            return this;
        }
        public IModelViewBinderWithCallback<TModel> Register<TPropertie, TControl, TConvertFromModel>(Expression<Func<TModel, TConvertFromModel>> expression, TControl control, Expression<Func<TControl, TPropertie>> controlExpression, Func<TConvertFromModel, TPropertie> convertFunction)
             where TControl : class
        {
            var register = new RegisterItem<TModel, TPropertie, TControl, TConvertFromModel>(expression, control, controlExpression, convertFunction, null);
            Add(register);

            return this;
        }
        public IModelViewBinderWithCallback<TModel> Register<TPropertie, TControl, TConvertFromModel>(Expression<Func<TModel, TConvertFromModel>> expression, TControl control, Expression<Func<TControl, TPropertie>> controlExpression, Func<TConvertFromModel, TPropertie> convertFromModelFunction, Func<TPropertie, TConvertFromModel> convertToModelFunction)
             where TControl : class
        {
            var register = new RegisterItem<TModel, TPropertie, TControl, TConvertFromModel>(expression, control, controlExpression, convertFromModelFunction, convertToModelFunction, null);
            Controls.Add(register);

            return this;
        }
        private void Add(IRegisterItem<TModel> item)
        {
            Controls.Add(item);
            LastRegister = item;
        }
        public void FillControls()
        {
            foreach (var item in Controls)
            {
                item.FillControl(Model);
            }
        }
        public void FillModel()
        {
            foreach (var item in Controls)
            {
                item.FillModel(Model);
            }
        }
        public IModelViewBinder<TModel> Then(Action action)
        {
            LastRegister.SetCallback(action);
            return this;
        }
        public void SetForm(Form form)
        {
            FillControls();
            foreach (var item in Controls)
            {
                IDisposable observable = null;

                if (item.GetControl() is IControlWithChangeEvent)
                {
                    var control = item.GetControl() as IControlWithChangeEvent;

                    observable = Observable.FromEventPattern<EventHandler, EventArgs>(
                       handler => handler.Invoke,
                       h => control.ValueChanged += h,
                       h => control.ValueChanged -= h)
                       .ObserveOn(form)
                       .Subscribe(e => item.FillModel(Model));
                }

                if (observable != null)
                    BindersToDispose.Add(observable);
            }
        }
        public TControl GetControlFromProperty<TControl>(string propertyName) where TControl : class
        {
            var result = default(TControl);

            var controlRegister = Controls.ToList().Where(e => e.GetPropertyInfo().Name == propertyName)?.FirstOrDefault();

            result = (TControl)controlRegister?.GetControl();

            return result;
        }
        public TControl GetControlFromProperty<TControl, TProperty>(Expression<Func<TModel, TProperty>> property) where TControl : class
        {
            return GetControlFromProperty<TControl>(property.GetPropertyInfo().Name);
        }
        public void DisableAll()
        {
            foreach (var item in Controls)
            {
                if (item is IControlWithEnabled)
                    ((IControlWithEnabled)item.GetControl()).Enabled = false;

                if (item is Control)
                    ((Control)item.GetControl()).Enabled = false;
            }
        }

        public void EnableAll()
        {
            foreach (var item in Controls)
            {
                if (item is IControlWithEnabled)
                    ((IControlWithEnabled)item.GetControl()).Enabled = true;

                if (item is Control)
                    ((Control)item.GetControl()).Enabled = true;
            }
        }
        public void Dispose()
        {
            foreach (var item in BindersToDispose)
            {
                item.Dispose();
            }
        }
    }

}
