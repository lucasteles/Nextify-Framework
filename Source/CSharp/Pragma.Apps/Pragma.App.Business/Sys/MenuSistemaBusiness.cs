using Pragma.App.DAO;
using Pragma.App.Model;
using Pragma.Business;
using Pragma.Business.Abstraction;

namespace Pragma.App.Business
{
    public interface IMenuSistemaBusiness : IBusiness<DbMenuSistema>
    {
    }
    public class MenuSistemaBusiness : BaseBusiness<DbMenuSistema>, IMenuSistemaBusiness
    {
        IDireitosUnitOfWork UserUnitOfWork;

        public MenuSistemaBusiness(IDireitosUnitOfWork UnitOfWork)
            : base(UnitOfWork, null, null)
        {
            UserUnitOfWork = UnitOfWork;
        }
    }
}
