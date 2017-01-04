
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IXMLModelRepository : IRepository<DbXMLModel>
    {

    }

    public class XMLModelRepository : BaseRepository<DbXMLModel>, IXMLModelRepository
    {
        public XMLModelRepository(IContext context) : base(context) 
        {
        }
    }
}

