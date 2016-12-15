using MetroFramework.Controls;
using Pragma.Extensions;
using Pragma.Forms.ControlBinding.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reactive.Linq;
using System.Windows.Forms;

namespace Pragma.Forms.ControlBinding
{



    public class ControlBinder<TModel> : IControlBinder<TModel>, IControlBinderWithCallback<TModel>
    {

        private TModel Model;

        private IList<IDisposable> BindersToDispose = new List<IDisposable>();
        public IList<IRegisterItem<TModel>> Controls { get; set; } = new List<IRegisterItem<TModel>>();

        protected IRegisterItem<TModel> LastRegister { get; set; }

        public ControlBinder()
        {

        }


        public IControlBinder<TModel> SetModel(TModel model)
        {
            if (model == null)
                throw new Exception("Model cant be null!");

            Model = model;

            return this;
        }

        public IControlBinderWithCallback<TModel> Register<TControl>(Expression<Func<TModel, object>> expression, TControl control) where TControl : Control, IControlWithValue
        {
            var register = new RegisterItem<TModel, object, TControl>(expression, control, e => e.Value);



            Add(register);

            return this;
        }

        public IControlBinderWithCallback<TModel> Register<TPropertie, TControl>(Expression<Func<TModel, TPropertie>> expression, TControl control, Expression<Func<TControl, TPropertie>> controlExpression) where TControl : Control
        {
            var register = new RegisterItem<TModel, TPropertie, TControl>(expression, control, controlExpression, null);
            Add(register);

            return this;
        }

        public IControlBinderWithCallback<TModel> Register<TPropertie, TControl, TConvertFromModel>(Expression<Func<TModel, TConvertFromModel>> expression, TControl control, Expression<Func<TControl, TPropertie>> controlExpression, Func<TConvertFromModel, TPropertie> convertFunction)
            where TControl : Control
        {
            var register = new RegisterItem<TModel, TPropertie, TControl, TConvertFromModel>(expression, control, controlExpression, convertFunction, null);
            Add(register);

            return this;
        }
        public IControlBinderWithCallback<TModel> Register<TPropertie, TControl, TConvertFromModel>(Expression<Func<TModel, TConvertFromModel>> expression, TControl control, Expression<Func<TControl, TPropertie>> controlExpression, Func<TConvertFromModel, TPropertie> convertFromModelFunction, Func<TPropertie, TConvertFromModel> convertToModelFunction)
            where TControl : Control
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

        public IControlBinder<TModel> Then(Action action)
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

                if (item.GetControl() is TextBoxBase)
                {
                    var txtcontrol = item.GetControl() as TextBoxBase;

                    observable = Observable.FromEventPattern<EventHandler, EventArgs>(
                       handler => handler.Invoke,
                       h => txtcontrol.TextChanged += h,
                       h => txtcontrol.TextChanged -= h)
                       .ObserveOn(form)
                       .Subscribe(e => item.FillModel(Model));
                }

                if (item.GetControl() is MetroTextBox)
                {
                    var txtcontrol = item.GetControl() as MetroTextBox;

                    observable = Observable.FromEventPattern<EventHandler, EventArgs>(
                       handler => handler.Invoke,
                       h => txtcontrol.TextChanged += h,
                       h => txtcontrol.TextChanged -= h)
                       .ObserveOn(form)
                       .Subscribe(e => item.FillModel(Model));
                }

                if (observable != null)
                    BindersToDispose.Add(observable);


            }


        }


        public TControl GetControlFromProperty<TControl>(string propertyName) where TControl : Control
        {
            TControl result = default(TControl);

            var controlRegister = Controls.ToList().Where(e => e.GetPropertyInfo().Name == propertyName)?.FirstOrDefault();

            result = controlRegister?.GetControl() as TControl;

            return result;
        }

        public TControl GetControlFromProperty<TControl, TProperty>(Expression<Func<TModel, TProperty>> property) where TControl : Control
        {
            return GetControlFromProperty<TControl>(property.GetPropertyInfo().Name);
        }

        public void DisableAll()
        {
            foreach (var item in Controls)
                item.GetControl().Enabled = false;
        }

        public void EnableAll()
        {
            foreach (var item in Controls)
                item.GetControl().Enabled = true;
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
