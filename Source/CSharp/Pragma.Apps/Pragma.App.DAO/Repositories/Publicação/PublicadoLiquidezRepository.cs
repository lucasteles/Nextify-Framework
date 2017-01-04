
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IPublicadoLiquidezRepository : IRepository<DbPublicadoLiquidez>
    {

    }

    public class PublicadoLiquidezRepository : BaseRepository<DbPublicadoLiquidez>, IPublicadoLiquidezRepository
    {
        public PublicadoLiquidezRepository(IContext context) : base(context) 
        {
        }
    }
}

