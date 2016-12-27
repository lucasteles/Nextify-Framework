using Pragma.Business.Abstraction;
using Pragma.Core;
using Pragma.Forms.Controllers.Abstraction;
using Pragma.Forms.Controls;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Pragma.Forms.Controllers
{

    public class GridViewController<TModel, TKey, TView> : AbstractGridBusinessController<TModel, TKey, TView>, IGridController<TView> where TModel : class, IModelWithId<TKey>, new() where TKey : struct
    {
        public GridViewController(IBusiness<TModel, TKey> business) : base(business)
        {
        }

        public override void SetPredicate(Expression<Func<TView, bool>> predicate)
        {
            Predicate = predicate;
        }

        private Expression<Func<TView, bool>> Predicate { get; set; }

        protected override async Task<IEnumerable<TView>> GetForGrid()
        {
            if (Predicate != null)
                return await Business.FindViewTopAsync(Predicate, QtdTopResult);
            else
                return await Business.GetViewTopAsync<TView>(QtdTopResult);
        }
    }

    public class GridViewController<TModel, TView> : GridViewController<TModel, int, TView> where TModel : class, IModelWithId, new()
    {
        public GridViewController(IBusiness<TModel, int> business) : base(business)
        {
        }
    }
}
