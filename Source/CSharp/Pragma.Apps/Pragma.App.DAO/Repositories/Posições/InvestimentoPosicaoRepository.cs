
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IInvestimentoPosicaoRepository : IRepository<DbInvestimentoPosicao,decimal>
    {

    }

    public class InvestimentoPosicaoRepository : BaseRepository<DbInvestimentoPosicao, decimal>, IInvestimentoPosicaoRepository
    {
        public InvestimentoPosicaoRepository(IContext context) : base(context) 
        {
        }
    }
}

