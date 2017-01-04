
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface ICotSaldoRepository : IRepository<DbCotSaldo,decimal>
    {

    }

    public class CotSaldoRepository : BaseRepository<DbCotSaldo, decimal>, ICotSaldoRepository
    {
        public CotSaldoRepository(IContext context) : base(context) 
        {
        }
    }
}

