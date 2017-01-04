using Pragma.App.Model.Posi��es;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface ICotaEspecialRepository : IRepository<DbCotaEspecial>
    {

    }

    public class CotaEspecialRepository : BaseRepository<DbCotaEspecial>, ICotaEspecialRepository
    {
        public CotaEspecialRepository(IContext context) : base(context) 
        {
        }
    }
}

