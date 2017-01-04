
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IEstrategiaRepository : IRepository<DbEstrategia>
    {

    }

    public class EstrategiaRepository : BaseRepository<DbEstrategia>, IEstrategiaRepository
    {
        public EstrategiaRepository(IContext context) : base(context)
        {
        }
    }
}

