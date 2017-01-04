
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IPagRecRepository : IRepository<DbPagRec>
    {

    }

    public class PagRecRepository : BaseRepository<DbPagRec>, IPagRecRepository
    {
        public PagRecRepository(IContext context) : base(context) 
        {
        }
    }
}

