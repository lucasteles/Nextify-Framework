
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IPptPaginaRepository : IRepository<DbPptPagina>
    {

    }

    public class PptPaginaRepository : BaseRepository<DbPptPagina>, IPptPaginaRepository
    {
        public PptPaginaRepository(IContext context) : base(context) 
        {
        }
    }
}

