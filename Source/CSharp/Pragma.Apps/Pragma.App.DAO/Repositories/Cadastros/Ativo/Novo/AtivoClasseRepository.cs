
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IAtivoClasseRepository : IRepository<DbAtivoClasse>
    {

    }

    public class AtivoClasseRepository : BaseRepository<DbAtivoClasse>, IAtivoClasseRepository
    {
        public AtivoClasseRepository(IContext context) : base(context) 
        {
        }
    }
}

