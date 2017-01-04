
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IInvestFechamentoRepository : IRepository<DbInvestFechamento,decimal>
    {

    }

    public class InvestFechamentoRepository : BaseRepository<DbInvestFechamento, decimal>, IInvestFechamentoRepository
    {
        public InvestFechamentoRepository(IContext context) : base(context) 
        {
        }
    }
}

