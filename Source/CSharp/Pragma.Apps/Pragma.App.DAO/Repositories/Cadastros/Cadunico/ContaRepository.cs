
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IContaRepository : IRepository<DbConta>
    {

    }

    public class ContaRepository : BaseRepository<DbConta>, IContaRepository
    {
        public ContaRepository(IContext context) : base(context) 
        {
        }
    }
}

