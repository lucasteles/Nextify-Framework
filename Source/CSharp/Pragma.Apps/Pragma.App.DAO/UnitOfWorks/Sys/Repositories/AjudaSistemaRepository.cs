
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IAjudaSistemaRepository : IRepository<DbAjudaSistema>
    {

    }

    public class AjudaSistemaRepository : BaseRepository<DbAjudaSistema>, IAjudaSistemaRepository
    {
        public AjudaSistemaRepository(IContext context) : base(context) 
        {
        }
    }
}

