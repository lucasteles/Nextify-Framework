using Pragma.Abstraction;
using Pragma.Abstraction.Business;
using Pragma.Abstraction.Forms.Controls;
using Pragma.Business.Abstraction;
using Pragma.Core;
using Pragma.Forms.Controllers.Abstraction;
using Pragma.Forms.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Pragma.Forms.Controllers
{
    public class ComboViewBaseController<TModel, TKey, TView, TViewKey> : 
            AbstractComboBusinessController<TModel, TKey, TView, TViewKey>, 
              IComboController<TView, TViewKey> where TModel : class, IModelWithKey<TKey>, new()
    {
        public ComboViewBaseController(IBusiness<TModel, TKey> business) : base(business)
        {
        }
        private Expression<Func<TView, bool>> Predicate { get; set; }
        private Func<TView, object> PredicateOrdem { get; set; }
        public override void SelectedChanceItem(TView o)
        {
            throw new NotImplementedException();
        }
        public override void SetOrder(Expression<Func<TView, object>> predicate)
        {
            PredicateOrdem = predicate.Compile();
        }

        public override void SetPredicate(Expression<Func<TView, bool>> predicate)
        {
            Predicate = predicate;
        }

        public override async Task<IEnumerable<TView>> GetForComboAsync()
        {
            IEnumerable<TView> list;
            list = Predicate != null || FilterInative ? await Business.GetAsync(TreatPredicate(Predicate)) : await Business.GetAsync<TView>();

            if (PredicateOrdem != null)
                list = list.OrderBy(PredicateOrdem);

            return list;
        }

        protected virtual Expression<Func<TView, bool>> TreatPredicate(Expression<Func<TView, bool>> predicate)
        {
            return predicate;
        }
    }
    public class ComboViewBaseController<TModel, TKey, TView> : ComboViewBaseController<TModel, TKey, TView, TKey> where TModel : class, IModelWithKey<TKey>, new()
    {
        public ComboViewBaseController(IBusiness<TModel, TKey> business) : base(business)
        {
        }
    }
    public class ComboViewBaseController<TModel, TKey> : ComboViewBaseController<TModel, TKey, TModel> where TModel : class, IModelWithKey<TKey>, new()
    {
        public ComboViewBaseController(IBusiness<TModel, TKey> business) : base(business)
        {
        }
    }
    public class ComboViewBaseController<TModel> : ComboViewBaseController<TModel, int, TModel> where TModel : class, IModelWithKey, new()
    {
        public ComboViewBaseController(IBusiness<TModel, int> business) : base(business)
        {
        }
    }
}
