
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IParametrosRepository : IRepository<DbParametros>
    {

    }

    public class ParametrosRepository : BaseRepository<DbParametros>, IParametrosRepository
    {
        public ParametrosRepository(IContext context) : base(context) 
        {
        }
    }
}

