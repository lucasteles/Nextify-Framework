
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IAtivoRegiaoRepository : IRepository<DbAtivoRegiao>
    {

    }

    public class AtivoRegiaoRepository : BaseRepository<DbAtivoRegiao>, IAtivoRegiaoRepository
    {
        public AtivoRegiaoRepository(IContext context) : base(context) 
        {
        }
    }
}

