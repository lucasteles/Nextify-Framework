
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IPptRelatorioTextoRepository : IRepository<DbPptRelatorioTexto>
    {

    }

    public class PptRelatorioTextoRepository : BaseRepository<DbPptRelatorioTexto>, IPptRelatorioTextoRepository
    {
        public PptRelatorioTextoRepository(IContext context) : base(context) 
        {
        }
    }
}

