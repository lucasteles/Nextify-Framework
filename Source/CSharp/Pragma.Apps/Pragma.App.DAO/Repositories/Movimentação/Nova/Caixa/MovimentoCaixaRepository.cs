
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IMovimentoCaixaRepository : IRepository<DbMovimentoCaixa>
    {

    }

    public class MovimentoCaixaRepository : BaseRepository<DbMovimentoCaixa>, IMovimentoCaixaRepository
    {
        public MovimentoCaixaRepository(IContext context) : base(context) 
        {
        }
    }
}

