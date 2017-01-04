
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IPublicadoIndiceRepository : IRepository<DbPublicadoIndice>
    {

    }

    public class PublicadoIndiceRepository : BaseRepository<DbPublicadoIndice>, IPublicadoIndiceRepository
    {
        public PublicadoIndiceRepository(IContext context) : base(context) 
        {
        }
    }
}

