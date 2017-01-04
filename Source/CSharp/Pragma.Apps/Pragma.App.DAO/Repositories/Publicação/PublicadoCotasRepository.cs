
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IPublicadoCotasRepository : IRepository<DbPublicadoCotas>
    {

    }

    public class PublicadoCotasRepository : BaseRepository<DbPublicadoCotas>, IPublicadoCotasRepository
    {
        public PublicadoCotasRepository(IContext context) : base(context) 
        {
        }
    }
}

