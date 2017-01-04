
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IIndiceCotacaoRepository : IRepository<DbIndiceCotacao>
    {

    }

    public class IndiceCotacaoRepository : BaseRepository<DbIndiceCotacao>, IIndiceCotacaoRepository
    {
        public IndiceCotacaoRepository(IContext context) : base(context) 
        {
        }
    }
}

