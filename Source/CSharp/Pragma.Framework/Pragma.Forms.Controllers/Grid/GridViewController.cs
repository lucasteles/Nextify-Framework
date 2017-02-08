using Equin.ApplicationFramework;
using Pragma.Abstraction;
using Pragma.Abstraction.Business;
using Pragma.Abstraction.Forms.Controls;
using Pragma.Business.Abstraction;
using Pragma.Core;

using Pragma.Extensions;
using Pragma.Forms.Controllers.Abstraction;
using Pragma.Forms.Controls;
using System;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;

namespace Pragma.Forms.Controllers
{
    public class GridViewController<TModel, TKey, TView> : GridViewBaseController<TModel, TKey, TView> where TModel : class, IModelWithKey<TKey>, new() where TView : IInative
    {
        public GridViewController(IBusiness<TModel, TKey> business) : base(business)
        {

            AddFormat(new ModelFormat { Strikeout = true }, (e, i, p) => e.Inative);
        }

        protected override Expression<Func<TView, bool>> TreatPredicate(Expression<Func<TView, bool>> predicate)
        {
            if (!FilterInative)
                return predicate;

            var filter = InativeModelHelper<TView>.InativeEquals(false);

            Expression<Func<TView, bool>> fluent;
            if (predicate != null)
            {
                fluent = new FluentLambda<TView>(predicate).And(filter).Exp();
            }
            else {
                fluent = filter;
            }

            
            return fluent; 
        }
    }

    public class GridViewBaseController<TModel, TKey, TView> : AbstractGridBusinessController<TModel, TKey, TView>, IGridController<TView> where TModel : class, IModelWithKey<TKey>, new()
    {
        protected IBusiness<TModel, TKey> KeyBasedBusiness;

        public GridViewBaseController(IBusiness<TModel, TKey> business) : base(business)
        {
            LoadFunctionWithFilter = Business.GetAsync;
            LoadFunction = Business.GetAsync<TView>;

            KeyBasedBusiness = business;
        }
        public override async Task RefreshDynamicSearchAsync()
        {
            var result = await Business.FindViewAllPropertiesAsync(QtdTopResult, TreatPredicate(Predicate), PgmGrid.FilterText.Split('|'));

            GridList = new BindingListView<TView>(result.ToList());
        }
        public override object GetSelectedModel()
        {
            return KeyBasedBusiness.GetForEdit((TKey)GetSelectedId());
        }
    }

    public class GridViewController<TModel, TView> : GridViewController<TModel, int, TView> where TModel : class, IModelWithKey, new() where TView : IInative
    {
        public GridViewController(IBusiness<TModel, int> business) : base(business)
        {
        }
    }

    public class GridViewBaseController<TModel, TView> : GridViewBaseController<TModel, int, TView>, IGridController<TView> where TModel : class, IModelWithKey, new()
    {
        public GridViewBaseController(IBusiness<TModel, int> business) : base(business)
        {
        }
    }




   
}

