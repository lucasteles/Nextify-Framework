
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IAlavancagemItemRepository : IRepository<DbAlavancagemItem>
    {

    }

    public class AlavancagemItemRepository : BaseRepository<DbAlavancagemItem>, IAlavancagemItemRepository
    {
        public AlavancagemItemRepository(IContext context) : base(context) 
        {
        }
    }
}

