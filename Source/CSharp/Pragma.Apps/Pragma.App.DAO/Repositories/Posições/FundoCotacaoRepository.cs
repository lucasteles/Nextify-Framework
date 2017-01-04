
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IFundoCotacaoRepository : IRepository<DbFundoCotacao,decimal>
    {

    }

    public class FundoCotacaoRepository : BaseRepository<DbFundoCotacao, decimal>, IFundoCotacaoRepository
    {
        public FundoCotacaoRepository(IContext context) : base(context) 
        {
        }
    }
}

