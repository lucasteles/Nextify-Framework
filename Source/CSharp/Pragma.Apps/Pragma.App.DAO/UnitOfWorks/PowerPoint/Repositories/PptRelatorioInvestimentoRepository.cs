
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IPptRelatorioInvestimentoRepository : IRepository<DbPptRelatorioInvestimento>
    {

    }

    public class PptRelatorioInvestimentoRepository : BaseRepository<DbPptRelatorioInvestimento>, IPptRelatorioInvestimentoRepository
    {
        public PptRelatorioInvestimentoRepository(IContext context) : base(context) 
        {
        }
    }
}

