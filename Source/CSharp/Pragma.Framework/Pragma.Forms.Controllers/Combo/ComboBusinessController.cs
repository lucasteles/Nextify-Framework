using Pragma.Abstraction;
using Pragma.Abstraction.Business;
using Pragma.Business.Abstraction;
using Pragma.Core;
using Pragma.Extensions;
using Pragma.Forms.Controllers.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Pragma.Forms.Controllers
{
    public class ComboBusinessController<TModel, TKey, TViewKey> : AbstractComboBusinessController<TModel, TKey, TModel, TViewKey> where TModel : class, IModelWithKey<TKey>, IBase, new()
    {
        public ComboBusinessController(IBusiness<TModel, TKey> business) : base(business)
        {
        }
        private Expression<Func<TModel, bool>> Predicate { get; set; }
        private Func<TModel, object> PredicateOrdem { get; set; }

        public override void SetPredicate(Expression<Func<TModel, bool>> predicate)
        {
            Predicate = predicate;
        }
        public override void SetOrder(Expression<Func<TModel, object>> predicate)
        {
            PredicateOrdem = predicate.Compile();
        }
        public override void SelectedChanceItem(TModel o)
        {

        }
        public override async Task<IEnumerable<TModel>> GetForComboAsync()
        {
            IEnumerable<TModel> list;
            list = Predicate != null || FilterInative ? await Business.GetAsync(TreatPredicate(Predicate)) : await Business.GetAsync();

            if (PredicateOrdem != null)
                list = list.OrderBy(PredicateOrdem);

            return list;
        }
        protected Expression<Func<TModel, bool>> TreatPredicate(Expression<Func<TModel, bool>> predicate)
        {
            if (!FilterInative)
                return predicate;

            var fluent = (predicate != null) ?
                new FluentLambda<TModel>(predicate).And(e => e.Inative == false).Exp() : e => e.Inative == false;

            return fluent;
        }
    }
    public class ComboBusinessController<TModel, TKey> : ComboBusinessController<TModel, TKey, TKey> where TModel : class, IModelWithKey<TKey>, IBase, new()
    {
        public ComboBusinessController(IBusiness<TModel, TKey> business) : base(business)
        {
        }

    }
    public class ComboBusinessController<TModel> : ComboBusinessController<TModel, int> where TModel : class, IModelWithKey, IBase, new()
    {
        public ComboBusinessController(IBusiness<TModel> business) : base(business)
        {
        }
    }
}
