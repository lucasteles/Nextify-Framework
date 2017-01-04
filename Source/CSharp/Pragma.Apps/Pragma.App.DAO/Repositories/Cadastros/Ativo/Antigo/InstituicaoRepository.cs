
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IInstituicaoRepository : IRepository<DbInstituicao>
    {

    }

    public class InstituicaoRepository : BaseRepository<DbInstituicao>, IInstituicaoRepository
    {
        public InstituicaoRepository(IContext context) : base(context) 
        {
        }
    }
}

