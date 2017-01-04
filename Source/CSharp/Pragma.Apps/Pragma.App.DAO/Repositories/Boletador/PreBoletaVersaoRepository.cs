
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IPreBoletaVersaoRepository : IRepository<DbPreBoletaVersao>
    {

    }

    public class PreBoletaVersaoRepository : BaseRepository<DbPreBoletaVersao>, IPreBoletaVersaoRepository
    {
        public PreBoletaVersaoRepository(IContext context) : base(context) 
        {
        }
    }
}

