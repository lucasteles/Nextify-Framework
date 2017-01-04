
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IInvestCarteiraRepository : IRepository<DbInvestCarteira,decimal>
    {

    }

    public class InvestCarteiraRepository : BaseRepository<DbInvestCarteira, decimal>, IInvestCarteiraRepository
    {
        public InvestCarteiraRepository(IContext context) : base(context) 
        {
        }
    }
}

