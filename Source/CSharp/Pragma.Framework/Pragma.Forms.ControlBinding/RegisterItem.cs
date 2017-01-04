using Pragma.Extensions;
using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Pragma.ModelViewBinder
{

    public interface IRegisterItem<TModel>
    {
        void FillControl(TModel model);
        void FillModel(TModel model);

        void SetCallback(Action callback);

        object GetControl();

        PropertyInfo GetPropertyInfo();

    }

    public class RegisterItem<TModel, TPropertie, TControl> : IRegisterItem<TModel>
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

            object value;
            if (model == null)
            {
                var prop = Property.GetPropertyInfo().PropertyType;
                value = GetDefault(prop);
                if (value == null && prop == typeof(string))
                    value = string.Empty;
            }
            else
                value = Property.GetPropertyInfo().GetValue(model);
            ControlProperty.GetPropertyInfo().SetValue(Control, value);

            Callback?.Invoke();

        }

        public static object GetDefault(Type t)
        {
            Func<object> f = GetDefault<object>;
            return f.Method.GetGenericMethodDefinition().MakeGenericMethod(t).Invoke(null, null);
        }

        private static T GetDefault<T>()
        {
            return default(T);
        }
        public virtual void FillModel(TModel model)
        {
            if (model == null)
                return;

            var value = ControlProperty.GetPropertyInfo().GetValue(Control);
            Property.GetPropertyInfo().SetValue(model, value);
        }

        public void SetCallback(Action callback)
        {
            Callback = callback;
        }

        public object GetControl()
        {
            return Control;
        }

        public PropertyInfo GetPropertyInfo()
        {
            return Property.GetPropertyInfo();
        }
    }

    public class RegisterItem<TModel, TPropertie, TControl, TConvertFromModel> : RegisterItem<TModel, TPropertie, TControl>, IRegisterItem<TModel>
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

            value = rawValue.GetType() == typeof(TConvertFromModel) ? ConvertFromModelFunction((TConvertFromModel)rawValue) : (TPropertie)rawValue;

            if (Control is IControlWithValue)
                ControlProperty.GetPropertyInfo().SetValue((Control as IControlWithValue), value);
            else
                ControlProperty.GetPropertyInfo().SetValue(Control, value);
            Callback?.Invoke();

        }

        public override void FillModel(TModel model)
        {

            if (ConvertToModelFunction == null)
                throw new Exception("Cant convert model data to control");

            object rawValue;
            rawValue = Control is IControlWithValue ? ControlProperty.GetPropertyInfo().GetValue((Control as IControlWithValue)) : ControlProperty.GetPropertyInfo().GetValue(Control);

            TConvertFromModel value;

            value = rawValue.GetType() == typeof(TPropertie) ? ConvertToModelFunction((TPropertie)rawValue) : (TConvertFromModel)rawValue;
            ModelPropertyToConv.GetPropertyInfo().SetValue(model, value);
        }

    }

}


