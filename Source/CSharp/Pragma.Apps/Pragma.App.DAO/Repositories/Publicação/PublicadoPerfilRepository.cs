
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IPublicadoPerfilRepository : IRepository<DbPublicadoPerfil>
    {

    }

    public class PublicadoPerfilRepository : BaseRepository<DbPublicadoPerfil>, IPublicadoPerfilRepository
    {
        public PublicadoPerfilRepository(IContext context) : base(context) 
        {
        }
    }
}

