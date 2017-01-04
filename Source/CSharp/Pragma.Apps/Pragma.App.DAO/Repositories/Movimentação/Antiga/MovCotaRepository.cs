
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IMovCotaRepository : IRepository<DbMovCota,decimal>
    {

    }

    public class MovCotaRepository : BaseRepository<DbMovCota, decimal>, IMovCotaRepository
    {
        public MovCotaRepository(IContext context) : base(context) 
        {
        }
    }
}

