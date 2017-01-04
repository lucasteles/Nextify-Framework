using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Pragma.ModelViewBinder
{

    public interface IModelViewBinder : IDisposable
    {

        void FillControls();
        void FillModel();

        void SetForm(Form form);

        TControl GetControlFromProperty<TControl>(string propertyName) where TControl : class;

        void DisableAll();

        void EnableAll();

    }

    public interface IModelViewBinder<TModel> : IModelViewBinder
    {
        IList<IRegisterItem<TModel>> Controls { get; set; }

        IModelViewBinderWithCallback<TModel> Register<TControl>(Expression<Func<TModel, object>> expression, TControl control) where TControl : class, IControlWithValue;

        IModelViewBinderWithCallback<TModel> Register<TPropertie, TControl>(Expression<Func<TModel, TPropertie>> expression, TControl control, Expression<Func<TControl, TPropertie>> controlExpression) where TControl : class;
        IModelViewBinderWithCallback<TModel> Register<TPropertie, TControl, TConvertFromModel>(Expression<Func<TModel, TConvertFromModel>> expression, TControl control, Expression<Func<TControl, TPropertie>> controlExpression, Func<TConvertFromModel, TPropertie> convertFunction) where TControl : class;
        IModelViewBinderWithCallback<TModel> Register<TPropertie, TControl, TConvertFromModel>(Expression<Func<TModel, TConvertFromModel>> expression, TControl control, Expression<Func<TControl, TPropertie>> controlExpression, Func<TConvertFromModel, TPropertie> convertFromModelFunction, Func<TPropertie, TConvertFromModel> convertToModelFunction) where TControl : class;
        IModelViewBinder<TModel> SetModel(TModel model);

        TControl GetControlFromProperty<TControl, TProperty>(Expression<Func<TModel, TProperty>> property) where TControl : class;

    }

    public interface IModelViewBinderWithCallback<TModel> : IModelViewBinder<TModel>
    {
        IModelViewBinder<TModel> Then(Action action);
    }

}