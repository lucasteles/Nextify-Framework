
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IEmpresaRepository : IRepository<DbEmpresa>
    {

    }

    public class EmpresaRepository : BaseRepository<DbEmpresa>, IEmpresaRepository
    {
        public EmpresaRepository(IContext context) : base(context) 
        {
        }
    }
}

