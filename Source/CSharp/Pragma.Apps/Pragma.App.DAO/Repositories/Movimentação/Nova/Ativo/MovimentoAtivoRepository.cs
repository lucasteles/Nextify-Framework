
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IMovimentoAtivoRepository : IRepository<DbMovimentoAtivo>
    {

    }

    public class MovimentoAtivoRepository : BaseRepository<DbMovimentoAtivo>, IMovimentoAtivoRepository
    {
        public MovimentoAtivoRepository(IContext context) : base(context) 
        {
        }
    }
}

