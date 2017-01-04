
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IConversaoMoedaRepository : IRepository<DbConversaoMoeda>
    {

    }

    public class ConversaoMoedaRepository : BaseRepository<DbConversaoMoeda>, IConversaoMoedaRepository
    {
        public ConversaoMoedaRepository(IContext context) : base(context) 
        {
        }
    }
}

