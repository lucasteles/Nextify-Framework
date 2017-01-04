
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IConciliacaoMotivoRepository : IRepository<DbConciliacaoMotivo>
    {

    }

    public class ConciliacaoMotivoRepository : BaseRepository<DbConciliacaoMotivo>, IConciliacaoMotivoRepository
    {
        public ConciliacaoMotivoRepository(IContext context) : base(context) 
        {
        }
    }
}

