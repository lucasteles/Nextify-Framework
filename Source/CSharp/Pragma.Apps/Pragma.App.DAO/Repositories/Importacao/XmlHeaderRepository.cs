
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IXmlHeaderRepository : IRepository<DbXmlHeader>
    {

    }

    public class XmlHeaderRepository : BaseRepository<DbXmlHeader>, IXmlHeaderRepository
    {
        public XmlHeaderRepository(IContext context) : base(context) 
        {
        }
    }
}

