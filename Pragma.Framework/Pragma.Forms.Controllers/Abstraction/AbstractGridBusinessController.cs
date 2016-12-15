using Pragma.Business.Abstraction;
using Pragma.Core;

namespace Pragma.Forms.Controllers.Abstraction
{
    public abstract class AbstractGridBusinessController<TModel, TKey, TView> : AbstractGridController<TView> where TModel : class, IModelWithId<TKey>, new() where TKey : struct
    {
        protected IBusiness<TModel, TKey> Business;

        public AbstractGridBusinessController(IBusiness<TModel, TKey> business)
        {
            Business = business;
        }

        public override IOperationResult TryDelete(object id)
        {
            if (!(id is TKey))
                throw new System.Exception("Id types dont match");

            var item = Business.Get((TKey)id);

            var result = Business.Remove(item);

            return result;

        }

        public override void Dispose()
        {
            Business.Dispose();
        }


    }
}
