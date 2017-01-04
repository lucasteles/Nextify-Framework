
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IPaisRepository : IRepository<DbPais,string>
    {

    }

    public class PaisRepository : BaseRepository<DbPais, string>, IPaisRepository
    {
        public PaisRepository(IContext context) : base(context) 
        {
        }
    }
}

