
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IAjusteRepository : IRepository<DbAjuste>
    {

    }

    public class AjusteRepository : BaseRepository<DbAjuste>, IAjusteRepository
    {
        public AjusteRepository(IContext context) : base(context) 
        {
        }
    }
}

