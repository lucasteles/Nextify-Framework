
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IAlavancagemRepository : IRepository<DbAlavancagem>
    {

    }

    public class AlavancagemRepository : BaseRepository<DbAlavancagem>, IAlavancagemRepository
    {
        public AlavancagemRepository(IContext context) : base(context) 
        {
        }
    }
}

