
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IAtivoSubClasseRepository : IRepository<DbAtivoSubClasse>
    {

    }

    public class AtivoSubClasseRepository : BaseRepository<DbAtivoSubClasse>, IAtivoSubClasseRepository
    {
        public AtivoSubClasseRepository(IContext context) : base(context) 
        {
        }
    }
}

