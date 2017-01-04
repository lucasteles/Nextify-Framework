
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface ILiquidacaoFormaRepository : IRepository<DbLiquidacaoForma>
    {

    }

    public class LiquidacaoFormaRepository : BaseRepository<DbLiquidacaoForma>, ILiquidacaoFormaRepository
    {
        public LiquidacaoFormaRepository(IContext context) : base(context) 
        {
        }
    }
}

