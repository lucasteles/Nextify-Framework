
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface ILiquidacaoTipoRepository : IRepository<DbLiquidacaoTipo,string>
    {

    }

    public class LiquidacaoTipoRepository : BaseRepository<DbLiquidacaoTipo, string>, ILiquidacaoTipoRepository
    {
        public LiquidacaoTipoRepository(IContext context) : base(context) 
        {
        }
    }
}

