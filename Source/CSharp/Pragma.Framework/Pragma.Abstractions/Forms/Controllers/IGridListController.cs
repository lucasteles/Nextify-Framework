using Pragma.Abstraction.Forms.Controls;

using System.Collections.Generic;

namespace Pragma.Abstraction.Forms.Controllers.GridItems
{
    public interface IGridListController<TView> : IGridController<TView>
    {
        IList<TView> Items { get; set; }
    }
}