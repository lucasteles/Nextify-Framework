
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IGalgoLogRepository : IRepository<DbGalgoLog>
    {

    }

    public class GalgoLogRepository : BaseRepository<DbGalgoLog>, IGalgoLogRepository
    {
        public GalgoLogRepository(IContext context) : base(context) 
        {
        }
    }
}

