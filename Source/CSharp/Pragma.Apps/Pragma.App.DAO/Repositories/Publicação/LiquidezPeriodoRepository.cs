
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface ILiquidezPeriodoRepository : IRepository<DbLiquidezPeriodo>
    {

    }

    public class LiquidezPeriodoRepository : BaseRepository<DbLiquidezPeriodo>, ILiquidezPeriodoRepository
    {
        public LiquidezPeriodoRepository(IContext context) : base(context) 
        {
        }
    }
}

