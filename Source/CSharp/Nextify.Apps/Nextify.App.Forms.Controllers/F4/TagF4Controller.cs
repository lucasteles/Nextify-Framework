using Nextify.Abstraction.Forms.Controls.Abstraction;
using Nextify.App.Models;
using Nextify.Forms.Controllers;
using Nextify.Abstraction.IOC;
using Nextify.App.Forms.Controllers.Grids;
using Nextify.App.Business;

namespace Nextify.App.Forms.Controllers.F4
{
    public interface ITagF4Controller : IF4Controller<Tag>
    {

    }

    public class TagF4Controller : F4Controller<Tag>, ITagF4Controller
    {
        public TagF4Controller(
            ITagGridController grid, 
            ITagBusiness business
            ) : base(grid, business)
        {
            

        }
    }
}
