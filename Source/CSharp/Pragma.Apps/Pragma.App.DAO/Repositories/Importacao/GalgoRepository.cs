
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IGalgoRepository : IRepository<DbGalgo>
    {

    }

    public class GalgoRepository : BaseRepository<DbGalgo>, IGalgoRepository
    {
        public GalgoRepository(IContext context) : base(context) 
        {
        }
    }
}

