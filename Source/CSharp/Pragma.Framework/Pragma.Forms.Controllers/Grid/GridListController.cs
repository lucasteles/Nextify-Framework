using Pragma.Forms.Controllers.Abstraction;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        protected override bool DoNestingFilter(TView model)
        {
            throw new Exception("This type of grid doesn't support nesting.");
        }

        protected override void ToggleNestedVisibility(DataGridViewCellMouseEventArgs eventArgs)
        {
            throw new Exception("This type of grid doesn't support nesting.");
        }

        protected override void Dummy()
        {
            throw new NotImplementedException();
        }
    }
}
