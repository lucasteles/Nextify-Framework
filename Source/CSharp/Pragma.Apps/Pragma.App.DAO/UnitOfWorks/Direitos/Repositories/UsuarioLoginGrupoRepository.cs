
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pragma.App.DAO.Repositories
{
    public interface IUsuarioLoginGrupoRepository : IRepository<DbUsuarioLoginGrupo>
    {

        Task<IEnumerable<DbUsuarioLoginGrupo>> GetUserAndGroupAsync(string login);
    }

    public class UsuarioLoginGrupoRepository : BaseRepository<DbUsuarioLoginGrupo>, IUsuarioLoginGrupoRepository
    {
        public UsuarioLoginGrupoRepository(IContext context) : base(context)
        {
        }

        public async Task<IEnumerable<DbUsuarioLoginGrupo>> GetUserAndGroupAsync(string login)
        {

            return await GetAsync(e => e.UsuLogin.Login == login, e => e.UsuGrupo, e => e.UsuLogin);
        }

    }

}

