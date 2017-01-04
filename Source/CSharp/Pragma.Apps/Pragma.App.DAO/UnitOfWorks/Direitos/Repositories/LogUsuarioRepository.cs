using Pragma.App.Model.Sys;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface ILogUsuarioRepository : IRepository<DbLogUsuario>
    {

    }

    public class LogUsuarioRepository : BaseRepository<DbLogUsuario>, ILogUsuarioRepository
    {
        public LogUsuarioRepository(IContext context) : base(context) 
        {
        }
    }
}

