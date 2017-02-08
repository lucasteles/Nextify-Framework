using Nextify.Abstraction.Forms.Controls;

using System.Collections.Generic;

namespace Nextify.Abstraction.Forms.Controllers.GridItems
{
    public interface IGridListController<TView> : IGridController<TView>
    {
        IList<TView> Items { get; set; }
    }
}