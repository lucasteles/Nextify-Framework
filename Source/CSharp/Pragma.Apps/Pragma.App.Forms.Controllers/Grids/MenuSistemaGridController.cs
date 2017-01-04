using Pragma.App.Business;
using Pragma.App.Model;
using Pragma.Forms.Controllers;
using Pragma.Forms.Controls;

namespace Pragma.App.Forms.Controllers.Grids
{
    public interface IMenuSistemaGridController : IGridController<DbMenuSistema>
    {
    }
    public class MenuSistemaGridController : GridController<DbMenuSistema>, IMenuSistemaGridController
    {
        public MenuSistemaGridController(IMenuSistemaBusiness business) : base(business)
        {
            UseDatabaseDynamicSearch = true;

            //SetPredicate(e => e.Inativo == 1);
        }
    }
}
