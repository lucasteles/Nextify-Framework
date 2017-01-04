
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IUsuarioGrupoRepository : IRepository<DbUsuarioGrupo>
    {

    }

    public class UsuarioGrupoRepository : BaseRepository<DbUsuarioGrupo>, IUsuarioGrupoRepository
    {
        public UsuarioGrupoRepository(IContext context) : base(context) 
        {
        }
    }
}

