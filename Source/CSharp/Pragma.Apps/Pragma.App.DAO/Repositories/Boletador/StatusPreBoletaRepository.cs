
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IStatusPreBoletaRepository : IRepository<DbStatusPreBoleta>
    {

    }

    public class StatusPreBoletaRepository : BaseRepository<DbStatusPreBoleta>, IStatusPreBoletaRepository
    {
        public StatusPreBoletaRepository(IContext context) : base(context) 
        {
        }
    }
}

