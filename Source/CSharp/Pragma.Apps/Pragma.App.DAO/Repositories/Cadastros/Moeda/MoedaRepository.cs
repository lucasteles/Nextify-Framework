
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IMoedaRepository : IRepository<DbMoeda,string>
    {

    }

    public class MoedaRepository : BaseRepository<DbMoeda, string>, IMoedaRepository
    {
        public MoedaRepository(IContext context) : base(context) 
        {
        }
    }
}

