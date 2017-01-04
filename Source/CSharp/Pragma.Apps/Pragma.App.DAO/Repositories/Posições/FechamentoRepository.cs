
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IFechamentoRepository : IRepository<DbFechamento,decimal>
    {

    }

    public class FechamentoRepository : BaseRepository<DbFechamento, decimal>, IFechamentoRepository
    {
        public FechamentoRepository(IContext context) : base(context) 
        {
        }
    }
}

