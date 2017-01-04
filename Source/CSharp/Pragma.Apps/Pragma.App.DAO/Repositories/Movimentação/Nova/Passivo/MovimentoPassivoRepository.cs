
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IMovimentoPassivoRepository : IRepository<DbMovimentoPassivo>
    {

    }

    public class MovimentoPassivoRepository : BaseRepository<DbMovimentoPassivo>, IMovimentoPassivoRepository
    {
        public MovimentoPassivoRepository(IContext context) : base(context) 
        {
        }
    }
}

