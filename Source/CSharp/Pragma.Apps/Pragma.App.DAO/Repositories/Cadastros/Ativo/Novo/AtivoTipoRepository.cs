
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IAtivoTipoRepository : IRepository<DbAtivoTipo>
    {

    }

    public class AtivoTipoRepository : BaseRepository<DbAtivoTipo>, IAtivoTipoRepository
    {
        public AtivoTipoRepository(IContext context) : base(context) 
        {
        }
    }
}

