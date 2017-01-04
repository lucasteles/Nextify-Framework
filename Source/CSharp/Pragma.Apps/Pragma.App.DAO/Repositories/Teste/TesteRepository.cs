
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface ITesteRepository : IRepository<DbTeste>
    {

    }

    public class TesteRepository : BaseRepository<DbTeste>, ITesteRepository
    {
        public TesteRepository(IContext context) : base(context) 
        {
        }
    }
}

