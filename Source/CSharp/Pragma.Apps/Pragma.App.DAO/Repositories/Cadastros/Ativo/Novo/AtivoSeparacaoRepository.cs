
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IAtivoSeparacaoRepository : IRepository<DbAtivoSeparacao>
    {

    }

    public class AtivoSeparacaoRepository : BaseRepository<DbAtivoSeparacao>, IAtivoSeparacaoRepository
    {
        public AtivoSeparacaoRepository(IContext context) : base(context) 
        {
        }
    }
}

