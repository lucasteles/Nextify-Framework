
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface ICadunicoRepository : IRepository<DbCadunico>
    {

    }

    public class CadunicoRepository : BaseRepository<DbCadunico>, ICadunicoRepository
    {
        public CadunicoRepository(IContext context) : base(context) 
        {
        }
    }
}

