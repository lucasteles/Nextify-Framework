using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;
using Pragma.Forms.Controls;

namespace Pragma.App.DAO.Repositories
{
    public interface IMenuSistemaRepository : IRepository<DbMenuSistema>
    {

    }

    public class MenuSistemaRepository : BaseRepository<DbMenuSistema>, IMenuSistemaRepository
    {
        public MenuSistemaRepository(IContext unitOfWork) : base(unitOfWork)
        {
        }
    }
}

