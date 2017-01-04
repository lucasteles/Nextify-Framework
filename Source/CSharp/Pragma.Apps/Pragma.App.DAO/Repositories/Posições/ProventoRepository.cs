
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IProventoRepository : IRepository<DbProvento>
    {

    }

    public class ProventoRepository : BaseRepository<DbProvento>, IProventoRepository
    {
        public ProventoRepository(IContext context) : base(context) 
        {
        }
    }
}

