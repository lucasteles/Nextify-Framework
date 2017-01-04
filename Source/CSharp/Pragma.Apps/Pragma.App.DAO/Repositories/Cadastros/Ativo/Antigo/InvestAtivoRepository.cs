
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IInvestAtivoRepository : IRepository<DbInvestAtivo,string>
    {

    }

    public class InvestAtivoRepository : BaseRepository<DbInvestAtivo, string>, IInvestAtivoRepository
    {
        public InvestAtivoRepository(IContext context) : base(context) 
        {
        }
    }
}

