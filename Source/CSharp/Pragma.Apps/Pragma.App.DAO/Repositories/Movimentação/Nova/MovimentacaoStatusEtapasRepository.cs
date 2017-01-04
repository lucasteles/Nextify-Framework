
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IMovimentacaoStatusEtapasRepository : IRepository<DbMovimentacaoStatusEtapas>
    {

    }

    public class MovimentacaoStatusEtapasRepository : BaseRepository<DbMovimentacaoStatusEtapas>, IMovimentacaoStatusEtapasRepository
    {
        public MovimentacaoStatusEtapasRepository(IContext context) : base(context) 
        {
        }
    }
}

