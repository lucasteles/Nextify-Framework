
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IAtivoConjuntoRepository : IRepository<DbAtivoConjunto,string>
    {

    }
    public class AtivoConjuntoRepository : BaseRepository<DbAtivoConjunto, string>, IAtivoConjuntoRepository
    {
        public AtivoConjuntoRepository(IContext context) : base(context) 
        {
        }
    }
}

