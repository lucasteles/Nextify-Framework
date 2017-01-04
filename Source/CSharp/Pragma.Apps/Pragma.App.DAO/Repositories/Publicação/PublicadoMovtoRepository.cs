
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IPublicadoMovtoRepository : IRepository<DbPublicadoMovto>
    {

    }

    public class PublicadoMovtoRepository : BaseRepository<DbPublicadoMovto>, IPublicadoMovtoRepository
    {
        public PublicadoMovtoRepository(IContext context) : base(context) 
        {
        }
    }
}

