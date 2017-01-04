
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IMandatoVersaoRepository : IRepository<DbMandatoVersao>
    {

    }

    public class MandatoVersaoRepository : BaseRepository<DbMandatoVersao>, IMandatoVersaoRepository
    {
        public MandatoVersaoRepository(IContext context) : base(context) 
        {
        }
    }
}

