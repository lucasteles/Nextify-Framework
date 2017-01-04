
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface ICotaOficialDivulgacaoRepository : IRepository<DbCotaOficialDivulgacao>
    {

    }

    public class CotaOficialDivulgacaoRepository : BaseRepository<DbCotaOficialDivulgacao>, ICotaOficialDivulgacaoRepository
    {
        public CotaOficialDivulgacaoRepository(IContext context) : base(context) 
        {
        }
    }
}

