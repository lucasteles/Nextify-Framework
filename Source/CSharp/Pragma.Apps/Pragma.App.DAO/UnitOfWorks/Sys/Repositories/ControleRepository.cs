
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IControleRepository : IRepository<DbControle>
    {

    }

    public class ControleRepository : BaseRepository<DbControle>, IControleRepository
    {
        public ControleRepository(IContext context) : base(context)
        {
        }
    }
}

