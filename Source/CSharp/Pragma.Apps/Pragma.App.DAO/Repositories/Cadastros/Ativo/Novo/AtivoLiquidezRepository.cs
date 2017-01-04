
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IAtivoLiquidezRepository : IRepository<DbAtivoLiquidez>
    {

    }

    public class AtivoLiquidezRepository : BaseRepository<DbAtivoLiquidez>, IAtivoLiquidezRepository
    {
        public AtivoLiquidezRepository(IContext context) : base(context) 
        {
        }
    }
}

