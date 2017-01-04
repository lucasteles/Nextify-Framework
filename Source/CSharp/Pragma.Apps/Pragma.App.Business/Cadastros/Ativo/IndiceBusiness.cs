using Pragma.App.Model;
using Pragma.Business;
using Pragma.Business.Abstraction;
using Pragma.DAO.Abstraction;

namespace Pragma.App.Business
{
    public interface IIndiceBusiness : IBusiness<DbIndice, string>
    {

    }
    public class IndiceBusiness : BaseBusiness<DbIndice, string>, IIndiceBusiness
    {
        public IndiceBusiness(IUnitOfWork UnitOfWork) : base(UnitOfWork, null, null)
        {
        }
    }
}
