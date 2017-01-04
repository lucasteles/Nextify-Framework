
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IOrigemExternaRepository : IRepository<DbOrigemExterna>
    {

    }

    public class OrigemExternaRepository : BaseRepository<DbOrigemExterna>, IOrigemExternaRepository
    {
        public OrigemExternaRepository(IContext context) : base(context) 
        {
        }
    }
}

