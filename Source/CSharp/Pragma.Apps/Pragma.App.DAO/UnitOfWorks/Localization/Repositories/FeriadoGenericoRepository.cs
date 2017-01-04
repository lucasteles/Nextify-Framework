
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IFeriadoGenericoRepository : IRepository<DbFeriadoGenerico>
    {

    }

    public class FeriadoGenericoRepository : BaseRepository<DbFeriadoGenerico>, IFeriadoGenericoRepository
    {
        public FeriadoGenericoRepository(IContext context) : base(context) 
        {
        }
    }
}

