
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IPptRelatorioRepository : IRepository<DbPptRelatorio>
    {

    }

    public class PptRelatorioRepository : BaseRepository<DbPptRelatorio>, IPptRelatorioRepository
    {
        public PptRelatorioRepository(IContext context) : base(context) 
        {
        }
    }
}

