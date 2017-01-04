
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface ICotaOficialRepository : IRepository<DbCotaOficial>
    {

    }

    public class CotaOficialRepository : BaseRepository<DbCotaOficial>, ICotaOficialRepository
    {
        public CotaOficialRepository(IContext context) : base(context) 
        {
        }
    }
}

