
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IInvestimentoMandatoRepository : IRepository<DbInvestimentoMandato>
    {

    }

    public class InvestimentoMandatoRepository : BaseRepository<DbInvestimentoMandato>, IInvestimentoMandatoRepository
    {
        public InvestimentoMandatoRepository(IContext context) : base(context) 
        {
        }
    }
}

