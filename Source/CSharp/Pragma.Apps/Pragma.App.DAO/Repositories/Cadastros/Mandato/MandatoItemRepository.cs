
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IMandatoItemRepository : IRepository<DbMandatoItem>
    {

    }

    public class MandatoItemRepository : BaseRepository<DbMandatoItem>, IMandatoItemRepository
    {
        public MandatoItemRepository(IContext context) : base(context) 
        {
        }
    }
}

