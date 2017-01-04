
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IMandatoRepository : IRepository<DbMandato,string>
    {

    }

    public class MandatoRepository : BaseRepository<DbMandato, string>, IMandatoRepository
    {
        public MandatoRepository(IContext context) : base(context) 
        {
        }
    }
}

