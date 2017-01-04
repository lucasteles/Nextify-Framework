
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IXmlCotasRepository : IRepository<DbXmlCotas>
    {

    }

    public class XmlCotasRepository : BaseRepository<DbXmlCotas>, IXmlCotasRepository
    {
        public XmlCotasRepository(IContext context) : base(context) 
        {
        }
    }
}

