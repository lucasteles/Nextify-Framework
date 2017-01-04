
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IAtivoIsentoRepository : IRepository<DbAtivoIsento,string>
    {

    }

    public class AtivoIsentoRepository : BaseRepository<DbAtivoIsento, string>, IAtivoIsentoRepository
    {
        public AtivoIsentoRepository(IContext context) : base(context) 
        {
        }
    }
}

