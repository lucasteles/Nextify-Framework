
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IAluguelRepository : IRepository<DbAluguel,decimal>
    {

    }

    public class AluguelRepository : BaseRepository<DbAluguel, decimal>, IAluguelRepository
    {
        public AluguelRepository(IContext context) : base(context) 
        {
        }
    }
}

