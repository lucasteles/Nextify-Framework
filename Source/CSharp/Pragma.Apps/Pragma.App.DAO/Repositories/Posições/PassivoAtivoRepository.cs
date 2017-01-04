
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IPassivoAtivoRepository : ISimpleRepository<DbPassivoAtivo>
    {

    }

    public class PassivoAtivoRepository : SimpleRepository<DbPassivoAtivo>, IPassivoAtivoRepository
    {
        public PassivoAtivoRepository(IContext context) : base(context) 
        {
        }
    }
}

