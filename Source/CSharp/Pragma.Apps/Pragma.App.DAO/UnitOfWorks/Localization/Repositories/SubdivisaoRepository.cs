
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface ISubdivisaoRepository : IRepository<DbSubdivisao>
    {

    }

    public class SubdivisaoRepository : BaseRepository<DbSubdivisao>, ISubdivisaoRepository
    {
        public SubdivisaoRepository(IContext context) : base(context) 
        {
        }
    }
}

