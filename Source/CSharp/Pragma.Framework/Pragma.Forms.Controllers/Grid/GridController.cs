using Equin.ApplicationFramework;
using Pragma.Abstraction;
using Pragma.Abstraction.Business;
using Pragma.Business.Abstraction;
using Pragma.Core;
using Pragma.Extensions;
using Pragma.Forms.Controllers.Abstraction;
using System;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Pragma.Forms.Controllers
{
    public class GridController<TModel, TKey> : AbstractGridBusinessController<TModel, TKey, TModel> where TModel : class, IModelWithKey<TKey>, IBase, new()
    {
        public GridController(IBusiness<TModel, TKey> business) : base(business)
        {
            AddFormat(new ModelFormat { Strikeout = true }, (e, i, p) => e.Inative);

            LoadFunctionWithFilter = Business.GetAsync;
            LoadFunction = Business.GetAsync;
        }
        public override object GetSelectedModel()
        {
            return GetSelected();
        }
        public async override Task RefreshDynamicSearchAsync()
        {
            var result = await Business.FindAllPropertiesAsync(QtdTopResult, TreatPredicate(Predicate), PgmGrid.FilterText.Split('|'));

            GridList = new BindingListView<TModel>(result.ToList());
        }
        protected override Expression<Func<TModel, bool>> TreatPredicate(Expression<Func<TModel, bool>> predicate)
        {
            if (!FilterInative)
                return predicate;

            var fluent = (predicate != null) ?
             new FluentLambda<TModel>(predicate).And(e => e.Inative == false).Exp() : e => e.Inative == false;

            return fluent;
        }
    }
    public class GridController<TModel> : GridController<TModel, int> where TModel : class, IModelWithKey, IBase, new()
    {
        public GridController(IBusiness<TModel> business) : base(business)
        {
        }
    }
}