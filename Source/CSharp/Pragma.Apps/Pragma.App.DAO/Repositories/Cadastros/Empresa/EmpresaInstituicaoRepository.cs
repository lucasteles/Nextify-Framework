
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IEmpresaInstituicaoRepository : IRepository<DbEmpresaInstituicao>
    {

    }

    public class EmpresaInstituicaoRepository : BaseRepository<DbEmpresaInstituicao>, IEmpresaInstituicaoRepository
    {
        public EmpresaInstituicaoRepository(IContext context) : base(context) 
        {
        }
    }
}

