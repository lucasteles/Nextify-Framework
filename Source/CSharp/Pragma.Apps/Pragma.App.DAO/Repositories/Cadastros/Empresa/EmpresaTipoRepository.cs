
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IEmpresaTipoRepository : IRepository<DbEmpresaTipo>
    {

    }

    public class EmpresaTipoRepository : BaseRepository<DbEmpresaTipo>, IEmpresaTipoRepository
    {
        public EmpresaTipoRepository(IContext context) : base(context) 
        {
        }
    }
}

