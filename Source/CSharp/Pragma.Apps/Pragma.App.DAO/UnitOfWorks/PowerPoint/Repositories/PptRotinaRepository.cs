
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IPptRotinaRepository : IRepository<DbPptRotina>
    {

    }

    public class PptRotinaRepository : BaseRepository<DbPptRotina>, IPptRotinaRepository
    {
        public PptRotinaRepository(IContext context) : base(context) 
        {
        }
    }
}

