
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IPreBoletaRepository : IRepository<DbPreBoleta>
    {

    }

    public class PreBoletaRepository : BaseRepository<DbPreBoleta>, IPreBoletaRepository
    {
        public PreBoletaRepository(IContext context) : base(context)
        {
        }
    }
}

