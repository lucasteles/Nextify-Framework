using Pragma.App.DAO;
using Pragma.App.Model;
using Pragma.Business;
using Pragma.Business.Abstraction;

namespace Pragma.App.Business
{
    public interface ISysBusiness : IBusiness<DbControle>
    {
    }
    public class SysBusiness : BaseBusiness<DbControle>, ISysBusiness
    {
        ISysUnitOfWork SysUnitOfWork;

        public SysBusiness(ISysUnitOfWork UnitOfWork)
            : base(UnitOfWork, null, null)
        {
            SysUnitOfWork = UnitOfWork;
        }
    }
}
