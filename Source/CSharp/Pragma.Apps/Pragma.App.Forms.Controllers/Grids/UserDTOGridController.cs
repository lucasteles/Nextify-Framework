using Pragma.App.Business;
using Pragma.App.Model;
using Pragma.App.Models.DTO;
using Pragma.Forms.Controllers;
using Pragma.Forms.Controls;

namespace Pragma.App.Forms.Controllers.Grids
{
    public interface IUserDTOGridController : IGridController<UserDTO>
    {
    }
    public class UserDTOGridController : GridViewBaseController<DbUsuarioLogin, UserDTO>, IUserDTOGridController
    {
        public UserDTOGridController(IUsuarioLoginBusiness business) : base(business)
        {
            UseDatabaseDynamicSearch = true;
        }
    }
}
