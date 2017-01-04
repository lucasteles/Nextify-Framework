
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IConciliacaoResultadoRepository : IRepository<DbConciliacaoResultado>
    {

    }

    public class ConciliacaoResultadoRepository : BaseRepository<DbConciliacaoResultado>, IConciliacaoResultadoRepository
    {
        public ConciliacaoResultadoRepository(IContext context) : base(context) 
        {
        }
    }
}

