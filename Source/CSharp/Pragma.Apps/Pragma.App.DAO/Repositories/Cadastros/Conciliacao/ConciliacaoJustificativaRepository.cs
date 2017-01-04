
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IConciliacaoJustificativaRepository : IRepository<DbConciliacaoJustificativa>
    {

    }

    public class ConciliacaoJustificativaRepository : BaseRepository<DbConciliacaoJustificativa>, IConciliacaoJustificativaRepository
    {
        public ConciliacaoJustificativaRepository(IContext context) : base(context) 
        {
        }
    }
}

