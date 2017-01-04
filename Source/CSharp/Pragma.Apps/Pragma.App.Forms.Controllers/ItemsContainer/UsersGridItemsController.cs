using Pragma.App.Model;
using Pragma.App.Models.DTO;
using Pragma.Forms.Controllers;
using Pragma.Forms.Controllers.GridItems;
using Pragma.Forms.Controls.Abstraction;

namespace Pragma.App.Forms.Controllers.GridItems
{
    public interface IUsuarioGridItemsController : IPragmaItemsContainerController
    {

    }
    public class UsuarioGridItemsController : PragmaItemsContainerController<DbUsuarioLogin, UserDTO>, IUsuarioGridItemsController
    {
        public UsuarioGridItemsController(IGridListController<UserDTO> gridController) : base(gridController)
        {

        }
    }
}
