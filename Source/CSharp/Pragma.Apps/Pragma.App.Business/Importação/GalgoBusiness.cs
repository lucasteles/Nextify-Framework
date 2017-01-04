using Pragma.App.DAO;
using Pragma.App.Model;
using Pragma.Business;
using Pragma.Business.Abstraction;

namespace Pragma.App.Business
{
    public interface IGalgoLogBusiness : IBusiness<DbGalgoLog>
    {

    }
    public class GalgoLogBusiness : BaseBusiness<DbGalgoLog>, IGalgoLogBusiness
    {
        readonly IGalgoUnitOfWork GalgoUnitOfWork;

        public GalgoLogBusiness(IGalgoUnitOfWork unitOfWork)
            : base(unitOfWork, null, null)
        {
            GalgoUnitOfWork = unitOfWork;
        }
    }
}
