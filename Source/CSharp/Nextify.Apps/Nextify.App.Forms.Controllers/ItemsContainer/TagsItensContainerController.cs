using Nextify.Abstraction.Forms.Controller;
using Nextify.App.Models;
using Nextify.Forms.Controllers.GridItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nextify.Abstraction.Forms.Controllers.GridItems;
using Nextify.App.Forms.Controllers.Grids;

namespace Nextify.App.Forms.Controllers.ItemsContainer
{
    public interface ITagsItensContainerController : IItemsContainerController
    {

    }

    public class TagsItensContainerController : ItemsContainerController<Tag>, ITagsItensContainerController
    {
        public TagsItensContainerController(IGridListController<Tag> gridForItemsController) : base(gridForItemsController)
        {

        }
    }
}
