
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IFeriadoRepository : IRepository<DbFeriado>
    {

    }

    public class FeriadoRepository : BaseRepository<DbFeriado>, IFeriadoRepository
    {
        public FeriadoRepository(IContext context) : base(context) 
        {
        }
    }
}

