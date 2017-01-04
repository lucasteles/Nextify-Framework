
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IXML5Repository : IRepository<DbXML5>
    {

    }

    public class XML5Repository : BaseRepository<DbXML5>, IXML5Repository
    {
        public XML5Repository(IContext context) : base(context) 
        {
        }
    }
}

