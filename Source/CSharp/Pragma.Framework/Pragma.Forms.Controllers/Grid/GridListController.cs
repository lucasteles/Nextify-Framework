using Pragma.Forms.Controllers.Abstraction;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pragma.Forms.Controllers.GridItems
{
    public class GridListController<TView> : AbstractGridController<TView>, IGridListController<TView>
    {
        public IList<TView> Items { get; set; }

        public GridListController()
        {
        }

        protected async override Task<IEnumerable<TView>> GetForGridAsync()
        {
            return await Task.FromResult(Items);
        }
    }
}
