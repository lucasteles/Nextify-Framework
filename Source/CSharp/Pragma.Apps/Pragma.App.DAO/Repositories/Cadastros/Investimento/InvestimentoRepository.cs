
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IInvestimentoRepository : IRepository<DbInvestimento,decimal>
    {

    }

    public class InvestimentoRepository : BaseRepository<DbInvestimento, decimal>, IInvestimentoRepository
    {
        public InvestimentoRepository(IContext context) : base(context) 
        {
        }
    }
}

