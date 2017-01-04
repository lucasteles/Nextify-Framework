
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IMovimentacaoEventoRepository : IRepository<DbMovimentacaoEvento>
    {

    }

    public class MovimentacaoEventoRepository : BaseRepository<DbMovimentacaoEvento>, IMovimentacaoEventoRepository
    {
        public MovimentacaoEventoRepository(IContext context) : base(context) 
        {
        }
    }
}

