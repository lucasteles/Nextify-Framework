using Pragma.App.Business;
using Pragma.App.Forms.Controllers.Grids;
using Pragma.App.Model;
using Pragma.Forms.Controllers;
using Pragma.Forms.Controls.Abstraction;
using Pragma.IOC;

namespace Pragma.App.Forms.Controllers.F4
{
    public interface IUsuarioLoginF4Controller : IF4Controller<DbUsuarioLogin>
    {
    }
    public class UsuarioLoginF4Controller : F4Controller<DbUsuarioLogin>, IUsuarioLoginF4Controller
    {
        public UsuarioLoginF4Controller(IUsuarioLoginGridController grid, IUsuarioLoginBusiness business, IContainer container) : base(grid, business, container)
        {
        }
    }
}
