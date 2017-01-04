
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IAtivoCotacaoRepository : IRepository<DbAtivoCotacao>
    {

    }

    public class AtivoCotacaoRepository : BaseRepository<DbAtivoCotacao>, IAtivoCotacaoRepository
    {
        public AtivoCotacaoRepository(IContext context) : base(context) 
        {
        }
    }
}

