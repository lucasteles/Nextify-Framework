
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IConciliacaoErroRepository : IRepository<DbConciliacaoErro>
    {

    }

    public class ConciliacaoErroRepository : BaseRepository<DbConciliacaoErro>, IConciliacaoErroRepository
    {
        public ConciliacaoErroRepository(IContext context) : base(context) 
        {
        }
    }
}

