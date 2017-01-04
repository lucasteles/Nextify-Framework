
using Pragma.App.Model;
using Pragma.DAO;
using Pragma.DAO.Abstraction;
using System.Linq;

namespace Pragma.App.DAO.Repositories
{
    public interface IUsuarioLoginRepository : IRepository<DbUsuarioLogin>
    {

    }

    public class UsuarioLoginRepository : BaseRepository<DbUsuarioLogin>, IUsuarioLoginRepository
    {
        public UsuarioLoginRepository(IContext context) : base(context)
        {
            IncludeForEdit(
                    e => e.ListGrups,
                    e => e.ListGrups.Select(g => g.UsuGrupo)
               );
        }

        public override IQueryable<DbUsuarioLogin> Get()
        {
            return Get(EditNavigationProperties.ToArray());
        }
    }

}

