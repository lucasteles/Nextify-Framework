
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IMovCartRepository : IRepository<DbMovCart>
    {

    }

    public class MovCartRepository : BaseRepository<DbMovCart>, IMovCartRepository
    {
        public MovCartRepository(IContext context) : base(context) 
        {
        }
    }
}

