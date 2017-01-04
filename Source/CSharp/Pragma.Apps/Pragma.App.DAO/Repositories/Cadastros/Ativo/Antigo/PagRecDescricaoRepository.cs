
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IPagRecDescricaoRepository : IRepository<DbPagRecDescricao>
    {

    }

    public class PagRecDescricaoRepository : BaseRepository<DbPagRecDescricao>, IPagRecDescricaoRepository
    {
        public PagRecDescricaoRepository(IContext context) : base(context) 
        {
        }
    }
}

