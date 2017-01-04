
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IMoedaIndiceRepository : IRepository<DbMoedaIndice>
    {

    }

    public class MoedaIndiceRepository : BaseRepository<DbMoedaIndice>, IMoedaIndiceRepository
    {
        public MoedaIndiceRepository(IContext context) : base(context) 
        {
        }
    }
}

