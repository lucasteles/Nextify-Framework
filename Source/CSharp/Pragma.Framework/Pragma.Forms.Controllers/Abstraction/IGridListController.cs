using Pragma.Forms.Controls;
using System.Collections.Generic;

namespace Pragma.Forms.Controllers
{
    public interface IGridListController<TView> : IGridController<TView>
    {
        IList<TView> Items { get; set; }
    }
}