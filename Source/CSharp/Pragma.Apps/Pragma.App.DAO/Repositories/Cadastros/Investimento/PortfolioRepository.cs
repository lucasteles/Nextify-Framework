
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IPortfolioRepository : IRepository<DbPortfolio,string>
    {

    }

    public class PortfolioRepository : BaseRepository<DbPortfolio, string>, IPortfolioRepository
    {
        public PortfolioRepository(IContext context) : base(context) 
        {
        }
    }
}

