using Pragma.App.Business;
using Pragma.App.Model;
using Pragma.Forms.Controllers;
using Pragma.Forms.Controls;

namespace Pragma.App.Forms.Controllers.Grids
{
    public interface IUsuarioLoginGridController : IGridController<DbUsuarioLogin>
    {
    }
    public class UsuarioLoginGridController : GridController<DbUsuarioLogin>, IUsuarioLoginGridController
    {
        public UsuarioLoginGridController(IUsuarioLoginBusiness business) : base(business)
        {
            UseDatabaseDynamicSearch = true;
        }
    }
}
