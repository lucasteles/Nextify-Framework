using Pragma.Extensions;
using Pragma.Forms.ControlBinding.Abstraction;
using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Forms;

namespace Pragma.Forms.ControlBinding
{

    public interface IRegisterItem<TModel>
    {
        void FillControl(TModel model);
        void FillModel(TModel model);

        void SetCallback(Action callback);

        Control GetControl();


        PropertyInfo GetPropertyInfo();

    }


    public class RegisterItem<TModel, TPropertie, TControl> : IRegisterItem<TModel> where TControl : Control
    {
        public Expression<Func<TModel, TPropertie>> Property { get; set; }
        public Expression<Func<TControl, TPropertie>> ControlProperty { get; set; }

        public TControl Control { get; set; }
        public Action Callback { get; set; }

        public RegisterItem(Expression<Func<TModel, TPropertie>> modelProperty, TControl control, Action callback = null)
        {
            if (!(control is IControlWithValue))
                throw new Exception("This control cannot be used without specify the property");


            Fill(modelProperty, control, e => (TPropertie)(e as IControlWithValue).Value, callback);
        }

        public RegisterItem(Expression<Func<TModel, TPropertie>> modelProperty, TControl control, Expression<Func<TControl, TPropertie>> controlProperty, Action callback = null)
        {
            Fill(modelProperty, control, controlProperty, callback);
        }


        protected void Fill(Expression<Func<TModel, TPropertie>> modelProperty, TControl control, Expression<Func<TControl, TPropertie>> controlProperty, Action callback = null)
        {
            Property = modelProperty;
            Control = control;
            ControlProperty = controlProperty;
            Callback = callback;


        }


        public virtual void FillControl(TModel model)
        {
            var value = Property.GetPropertyInfo().GetValue(model);
            ControlProperty.GetPropertyInfo().SetValue(Control, value);

            Callback?.Invoke();

        }

        public virtual void FillModel(TModel model)
        {
            var value = ControlProperty.GetPropertyInfo().GetValue(Control);
            Property.GetPropertyInfo().SetValue(model, value);
        }

        public void SetCallback(Action callback)
        {
            Callback = callback;
        }

        public Control GetControl()
        {
            return Control;
        }

        public PropertyInfo GetPropertyInfo()
        {
            return Property.GetPropertyInfo();
        }
    }

    public class RegisterItem<TModel, TPropertie, TControl, TConvertFromModel> : RegisterItem<TModel, TPropertie, TControl>, IRegisterItem<TModel> where TControl : Control
    {

        public Expression<Func<TModel, TConvertFromModel>> ModelPropertyToConv { get; set; }
        public Func<TConvertFromModel, TPropertie> ConvertFromModelFunction { get; set; }

        public Func<TPropertie, TConvertFromModel> ConvertToModelFunction { get; set; } = null;

        public RegisterItem(Expression<Func<TModel, TConvertFromModel>> modelProperty, TControl control, Expression<Func<TControl, TPropertie>> controlProperty, Func<TConvertFromModel, TPropertie> convertFunction, Action callback = null)
            : base(null, control, controlProperty, callback)
        {
            ConvertFromModelFunction = convertFunction;
            ModelPropertyToConv = modelProperty;
        }

        public RegisterItem(Expression<Func<TModel, TConvertFromModel>> modelProperty, TControl control, Expression<Func<TControl, TPropertie>> controlProperty, Func<TConvertFromModel, TPropertie> convertFromModelFunction, Func<TPropertie, TConvertFromModel> convertToModelFunction, Action callback = null)
           : base(null, control, controlProperty, callback)
        {
            ConvertFromModelFunction = convertFromModelFunction;
            ModelPropertyToConv = modelProperty;
            ConvertToModelFunction = convertToModelFunction;
        }


        public override void FillControl(TModel model)
        {
            if (ConvertFromModelFunction == null)
                throw new Exception("Cant convert control data to model");


            var rawValue = ModelPropertyToConv.GetPropertyInfo().GetValue(model);
            TPropertie value;

            if (rawValue.GetType() == typeof(TConvertFromModel))
                value = ConvertFromModelFunction((TConvertFromModel)rawValue);
            else
                value = (TPropertie)rawValue;

            ControlProperty.GetPropertyInfo().SetValue(Control, value);

            Callback?.Invoke();

        }

        public override void FillModel(TModel model)
        {

            if (ConvertToModelFunction == null)
                throw new Exception("Cant convert model data to control");

            var rawValue = ControlProperty.GetPropertyInfo().GetValue(Control);
            TConvertFromModel value;

            if (rawValue.GetType() == typeof(TPropertie))
                value = ConvertToModelFunction((TPropertie)rawValue);
            else
                value = (TConvertFromModel)rawValue;

            ModelPropertyToConv.GetPropertyInfo().SetValue(model, value);
        }


    }


}


