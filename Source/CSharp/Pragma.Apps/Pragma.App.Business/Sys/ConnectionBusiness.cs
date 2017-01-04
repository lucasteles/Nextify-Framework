using Pragma.App.DAO;
using Pragma.App.Model;
using Pragma.Business;
using Pragma.Business.Abstraction;

namespace Pragma.App.Business
{
    public interface IConnectionBusiness : IBusiness<DbComboConnection>
    {
    }
    public class ConnectionBusiness : BaseBusiness<DbComboConnection>, IConnectionBusiness
    {
        IComboUnitOfWork ComboUnitOfWork;

        public ConnectionBusiness(IComboUnitOfWork UnitOfWork)
            : base(UnitOfWork, null, null)
        {
            ComboUnitOfWork = UnitOfWork;
        }
    }
}
