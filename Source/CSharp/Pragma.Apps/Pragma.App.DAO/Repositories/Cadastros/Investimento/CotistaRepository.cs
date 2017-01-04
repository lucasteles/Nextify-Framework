
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface ICotistaRepository : IRepository<DbCotista,decimal>
    {

    }

    public class CotistaRepository : BaseRepository<DbCotista, decimal>, ICotistaRepository
    {
        public CotistaRepository(IContext context) : base(context) 
        {
        }
    }
}

