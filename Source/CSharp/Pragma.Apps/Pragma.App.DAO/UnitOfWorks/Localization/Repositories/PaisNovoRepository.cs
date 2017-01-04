
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IPaisNovoRepository : IRepository<DbPaisNovo, string>
    {

    }

    public class PaisNovoRepository : BaseRepository<DbPaisNovo, string>, IPaisNovoRepository
    {
        public PaisNovoRepository(IContext context) : base(context) 
        {
        }
    }
}

