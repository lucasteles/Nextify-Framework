
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IAtivoClassificacaoRepository : IRepository<DbAtivoClassificacao>
    {

    }

    public class AtivoClassificacaoRepository : BaseRepository<DbAtivoClassificacao>, IAtivoClassificacaoRepository
    {
        public AtivoClassificacaoRepository(IContext context) : base(context) 
        {
        }
    }
}

