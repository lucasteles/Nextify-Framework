using Pragma.App.DAO.Repositories;
using Pragma.DAO;
using Pragma.DAO.Abstraction;
using System;

namespace Pragma.App.DAO
{
    public interface IDireitosUnitOfWork : IUnitOfWork
    {
        IUsuarioLoginRepository UsuarioLogin { get; set; }
        IUsuarioLoginGrupoRepository UsuarioLoginGrupo { get; set; }
        IUsuarioGrupoRepository UsuarioGrupo { get; set; }
    }

    public class DireitosUnitOfWork : BaseUnitOfWork, IDireitosUnitOfWork
    {
        public IUsuarioLoginRepository UsuarioLogin { get; set; }
        public IUsuarioLoginGrupoRepository UsuarioLoginGrupo { get; set; }
        public IUsuarioGrupoRepository UsuarioGrupo { get; set; }

        public DireitosUnitOfWork(
                SysContext context,
                 Func<IContext, IUsuarioLoginRepository> usuarioLogin,
                 Func<IContext, IUsuarioLoginGrupoRepository> usuarioLoginGrupo,
                 Func<IContext, IUsuarioGrupoRepository> usuarioGrupo
        ) : base(context)
        {

            UsuarioGrupo = usuarioGrupo(context);
            UsuarioLoginGrupo = usuarioLoginGrupo(context);
            UsuarioLogin = usuarioLogin(context);

        }
    }
}
