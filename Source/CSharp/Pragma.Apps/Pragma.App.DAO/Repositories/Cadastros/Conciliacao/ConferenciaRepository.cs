
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IConferenciaRepository : IRepository<DbConferencia>
    {

    }

    public class ConferenciaRepository : BaseRepository<DbConferencia>, IConferenciaRepository
    {
        public ConferenciaRepository(IContext context) : base(context) 
        {
        }
    }
}

