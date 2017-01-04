
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IInvestimentoTipoRepository : IRepository<DbInvestimentoTipo, decimal>
    {

    }

    public class InvestimentoTipoRepository : BaseRepository<DbInvestimentoTipo, decimal>, IInvestimentoTipoRepository
    {
        public InvestimentoTipoRepository(IContext context) : base(context)
        {
        }
    }
}

