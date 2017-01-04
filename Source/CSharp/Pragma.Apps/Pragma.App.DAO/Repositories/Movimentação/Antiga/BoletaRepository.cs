using Pragma.App.Model.Movimenta��o;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IBoletaRepository : IRepository<DbBoleta, decimal>
    {

    }

    public class BoletaRepository : BaseRepository<DbBoleta, decimal>, IBoletaRepository
    {
        public BoletaRepository(IContext context) : base(context) 
        {
        }
    }
}

