
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IIndiceRepository : IRepository<DbIndice,string>
    {

    }

    public class IndiceRepository : BaseRepository<DbIndice, string>, IIndiceRepository
    {
        public IndiceRepository(IContext context) : base(context) 
        {
        }
    }
}

