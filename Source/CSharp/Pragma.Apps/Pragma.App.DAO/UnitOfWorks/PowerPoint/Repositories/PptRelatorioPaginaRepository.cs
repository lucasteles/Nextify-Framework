
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;

namespace Pragma.App.DAO.Repositories
{
    public interface IPptRelatorioPaginaRepository : IRepository<DbPptRelatorioPagina>
    {

    }

    public class PptRelatorioPaginaRepository : BaseRepository<DbPptRelatorioPagina>, IPptRelatorioPaginaRepository
    {
        public PptRelatorioPaginaRepository(IContext context) : base(context) 
        {
        }
    }
}

