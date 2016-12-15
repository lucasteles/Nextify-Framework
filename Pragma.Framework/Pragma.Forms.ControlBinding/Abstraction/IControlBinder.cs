using Pragma.Forms.ControlBinding.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Pragma.Forms.ControlBinding
{
    public interface IControlBinder : IDisposable
    {
        void FillControls();
        void FillModel();

        void SetForm(Form form);

        TControl GetControlFromProperty<TControl>(string propertyName) where TControl : Control;

        void DisableAll();

        void EnableAll();

    }


    public interface IControlBinder<TModel> : IControlBinder
    {
        IList<IRegisterItem<TModel>> Controls { get; set; }

        IControlBinderWithCallback<TModel> Register<TControl>(Expression<Func<TModel, object>> expression, TControl control) where TControl : Control, IControlWithValue;

        IControlBinderWithCallback<TModel> Register<TPropertie, TControl>(Expression<Func<TModel, TPropertie>> expression, TControl control, Expression<Func<TControl, TPropertie>> controlExpression) where TControl : Control;
        IControlBinderWithCallback<TModel> Register<TPropertie, TControl, TConvertFromModel>(Expression<Func<TModel, TConvertFromModel>> expression, TControl control, Expression<Func<TControl, TPropertie>> controlExpression, Func<TConvertFromModel, TPropertie> convertFunction) where TControl : Control;
        IControlBinderWithCallback<TModel> Register<TPropertie, TControl, TConvertFromModel>(Expression<Func<TModel, TConvertFromModel>> expression, TControl control, Expression<Func<TControl, TPropertie>> controlExpression, Func<TConvertFromModel, TPropertie> convertFromModelFunction, Func<TPropertie, TConvertFromModel> convertToModelFunction) where TControl : Control;
        IControlBinder<TModel> SetModel(TModel model);


        TControl GetControlFromProperty<TControl, TProperty>(Expression<Func<TModel, TProperty>> property) where TControl : Control;


    }

    public interface IControlBinderWithCallback<TModel> : IControlBinder<TModel>
    {
        IControlBinder<TModel> Then(Action action);
    }


}