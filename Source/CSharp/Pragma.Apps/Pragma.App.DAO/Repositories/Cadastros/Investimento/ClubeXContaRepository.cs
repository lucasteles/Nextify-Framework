
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IClubeXContaRepository : IRepository<DbClubeXConta>
    {

    }

    public class ClubeXContaRepository : BaseRepository<DbClubeXConta>, IClubeXContaRepository
    {
        public ClubeXContaRepository(IContext context) : base(context) 
        {
        }
    }
}

