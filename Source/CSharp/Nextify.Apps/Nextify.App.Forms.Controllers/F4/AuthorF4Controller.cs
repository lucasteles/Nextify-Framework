using Nextify.Abstraction.Forms.Controls.Abstraction;
using Nextify.App.Models;
using Nextify.Forms.Controllers;
using Nextify.Abstraction.IOC;
using Nextify.App.Forms.Controllers.Grids;
using Nextify.App.Business;

namespace Nextify.App.Forms.Controllers.F4
{
    public interface IAuthorF4Controller : IF4Controller<Author>
    {

    }

    public class AuthorF4Controller : F4Controller<Author>, IAuthorF4Controller
    {
        public AuthorF4Controller(
            IAuthorGridController grid, 
            IAuthorBusiness business, 
            IContainer container) : base(grid, business)
        {


        }
    }
}
