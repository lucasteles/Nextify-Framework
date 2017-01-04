
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IUsuExternoRepository : IRepository<DbUsuExterno>
    {

    }

    public class UsuExternoRepository : BaseRepository<DbUsuExterno>, IUsuExternoRepository
    {
        public UsuExternoRepository(IContext context) : base(context) 
        {
        }
    }
}

