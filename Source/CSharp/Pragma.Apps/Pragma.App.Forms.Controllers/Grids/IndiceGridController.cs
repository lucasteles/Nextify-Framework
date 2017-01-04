using Pragma.App.Business;
using Pragma.App.Model;
using Pragma.Forms.Controllers;

namespace Pragma.App.Forms.Controllers.Grids
{
    public interface IIndiceGridController
    {
    }
    public class IndiceGridController : GridController<DbIndice, string>, IIndiceGridController
    {
        public IndiceGridController(IIndiceBusiness business) : base(business)
        {
        }
    }
}
