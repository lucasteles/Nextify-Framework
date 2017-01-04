
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IAtivoTipoControleRepository : IRepository<DbAtivoTipoControle>
    {

    }

    public class AtivoTipoControleRepository : BaseRepository<DbAtivoTipoControle>, IAtivoTipoControleRepository
    {
        public AtivoTipoControleRepository(IContext context) : base(context) 
        {
        }
    }
}

