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

    public class GridController<TModel, TKey> : AbstractGridBusinessController<TModel, TKey, TModel>, IGridController<TModel> where TModel : class, IModelWithId<TKey>, new() where TKey : struct
    {
        public GridController(IBusiness<TModel, TKey> business) : base(business)
        {
        }

        private Expression<Func<TModel, bool>> Predicate { get; set; } = null;

        protected override async Task<IEnumerable<TModel>> GetForGrid()
        {
            if (Predicate != null)
                return await Business.FindTopAsync(Predicate, QtdTopResult);
            else
                return await Business.GetTopAsync(QtdTopResult);
        }

        public override void SetPredicate(Expression<Func<TModel, bool>> predicate)
        {
            Predicate = predicate;
        }
    }


    public class GridController<TModel> : GridController<TModel, int> where TModel : class, IModelWithId, new()
    {
        public GridController(IBusiness<TModel> business) : base(business)
        {
        }
    }



}