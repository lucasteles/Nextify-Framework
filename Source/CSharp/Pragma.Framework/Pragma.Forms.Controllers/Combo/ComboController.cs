using Pragma.Core;
using Pragma.Forms.Controllers.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Pragma.Forms.Controllers
{
    public class ComboController<TView, TViewKey> : AbstractComboController<TView, TViewKey> where TView : class, new()
    {
        public ComboController()
        {
        }
        private Expression<Func<TView, bool>> Predicate { get; set; }
        private Func<TView, object> PredicateOrdem { get; set; }

        public override void SetPredicate(Expression<Func<TView, bool>> predicate)
        {
            Predicate = predicate;
        }
        public override void SetOrder(Expression<Func<TView, object>> predicate)
        {
            PredicateOrdem = predicate.Compile();
        }
        public override void SelectedChanceItem(TView o)
        {

        }
        protected static Expression<Func<TView, bool>> TreatPredicate(Expression<Func<TView, bool>> predicate)
        {
            return predicate;
        }
        public override Task<IEnumerable<TView>> GetForComboAsync()
        {
            throw new NotImplementedException();
        }
    }

    public class ComboController<TView> : ComboController<TView, int> where TView : class, new()
    {
        public ComboController()
        {
        }
    }
}
