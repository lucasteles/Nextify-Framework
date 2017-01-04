using Pragma.App.Model.Posi��es;
using Pragma.DAO;
using Pragma.DAO.Abstraction;
namespace Pragma.App.DAO.Repositories
{
    public interface IEstCotaRepository : IRepository<DbEstCota>
    {

    }

    public class EstCotaRepository : BaseRepository<DbEstCota>, IEstCotaRepository
    {
        public EstCotaRepository(IContext context) : base(context) 
        {
        }
    }
}

