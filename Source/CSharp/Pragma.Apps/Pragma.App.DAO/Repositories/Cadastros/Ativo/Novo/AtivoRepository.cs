
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IAtivoRepository : IRepository<DbAtivo,string>
    {

    }

    public class AtivoRepository : BaseRepository<DbAtivo, string>, IAtivoRepository
    {
        public AtivoRepository(IContext context) : base(context) 
        {
        }
    }
}

