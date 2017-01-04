
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IConciliacaoExecucaoRepository : IRepository<DbConciliacaoExecucao>
    {

    }

    public class ConciliacaoExecucaoRepository : BaseRepository<DbConciliacaoExecucao>, IConciliacaoExecucaoRepository
    {
        public ConciliacaoExecucaoRepository(IContext context) : base(context) 
        {
        }
    }
}

