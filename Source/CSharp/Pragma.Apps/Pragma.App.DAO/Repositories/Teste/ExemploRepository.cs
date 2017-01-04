
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IExemploRepository : IRepository<DbExemplo,string>
    {

    }

    public class ExemploRepository : BaseRepository<DbExemplo, string>, IExemploRepository
    {
        public ExemploRepository(IContext context) : base(context) 
        {
        }
    }
}

