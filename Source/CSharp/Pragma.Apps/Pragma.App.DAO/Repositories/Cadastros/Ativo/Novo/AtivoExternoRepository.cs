
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IAtivoExternoRepository : IRepository<DbAtivoExterno>
    {

    }

    public class AtivoExternoRepository : BaseRepository<DbAtivoExterno>, IAtivoExternoRepository
    {
        public AtivoExternoRepository(IContext context) : base(context) 
        {
        }
    }
}

