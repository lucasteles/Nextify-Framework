
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IMovimentacaoStatusRepository : IRepository<DbMovimentacaoStatus>
    {

    }

    public class MovimentacaoStatusRepository : BaseRepository<DbMovimentacaoStatus>, IMovimentacaoStatusRepository
    {
        public MovimentacaoStatusRepository(IContext context) : base(context) 
        {
        }
    }
}

