
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface ILiquidacaoModoRepository : IRepository<DbLiquidacaoModo,string>
    {

    }

    public class LiquidacaoModoRepository : BaseRepository<DbLiquidacaoModo, string>, ILiquidacaoModoRepository
    {
        public LiquidacaoModoRepository(IContext context) : base(context) 
        {
        }
    }
}

