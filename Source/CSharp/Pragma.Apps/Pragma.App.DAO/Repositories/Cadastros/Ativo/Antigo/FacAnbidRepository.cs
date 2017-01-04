
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IFacAnbidRepository : IRepository<DbFacAnbid,string>
    {

    }

    public class FacAnbidRepository : BaseRepository<DbFacAnbid, string>, IFacAnbidRepository
    {
        public FacAnbidRepository(IContext context) : base(context) 
        {
        }
    }
}

