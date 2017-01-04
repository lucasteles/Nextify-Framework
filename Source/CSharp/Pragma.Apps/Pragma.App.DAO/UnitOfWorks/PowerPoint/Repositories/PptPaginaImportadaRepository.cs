
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IPptPaginaImportadaRepository : IRepository<DbPptPaginaImportada>
    {

    }

    public class PptPaginaImportadaRepository : BaseRepository<DbPptPaginaImportada>, IPptPaginaImportadaRepository
    {
        public PptPaginaImportadaRepository(IContext context) : base(context) 
        {
        }
    }
}

