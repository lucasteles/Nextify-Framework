
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface ICidadeNovoRepository : IRepository<DbCidadeNovo>
    {

    }

    public class CidadeNovoRepository : BaseRepository<DbCidadeNovo>, ICidadeNovoRepository
    {
        public CidadeNovoRepository(IContext context) : base(context) 
        {
        }
    }
}

