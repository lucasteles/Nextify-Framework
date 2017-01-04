
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IAtivoLiquidezRegraRepository : IRepository<DbAtivoLiquidezRegra>
    {

    }

    public class AtivoLiquidezRegraRepository : BaseRepository<DbAtivoLiquidezRegra>, IAtivoLiquidezRegraRepository
    {
        public AtivoLiquidezRegraRepository(IContext context) : base(context) 
        {
        }
    }
}

