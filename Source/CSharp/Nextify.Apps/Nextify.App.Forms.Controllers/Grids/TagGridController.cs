using Nextify.Abstraction.Forms.Controls;
using Nextify.App.Models;
using Nextify.Forms.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nextify.Abstraction.Business;
using Nextify.App.Business;

namespace Nextify.App.Forms.Controllers.Grids
{
    public interface ITagGridController : IGridController<Tag>
    {

    }

    public class TagGridController : GridController<Tag>, ITagGridController
    {
        public TagGridController(ITagBusiness business) : base(business)
        {


        }
    }
}
