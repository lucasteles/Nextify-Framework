
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IMovimentoAtivoItemRepository : IRepository<DbMovimentoAtivoItem>
    {

    }

    public class MovimentoAtivoItemRepository : BaseRepository<DbMovimentoAtivoItem>, IMovimentoAtivoItemRepository
    {
        public MovimentoAtivoItemRepository(IContext context) : base(context) 
        {
        }
    }
}

