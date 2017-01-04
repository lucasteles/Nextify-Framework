
using FakeItEasy;
using Pragma.App.DAO.Repositories;
using Pragma.App.Model;
using Pragma.Tests;
using System.Collections.Generic;

namespace Pragma.App.DAO.Tests
{
    public class FakeUnitOfWorkFactory
    {
        public static IDireitosUnitOfWork GetFakeUserUnitOfWork()
        {
            IDireitosUnitOfWork result;
            #region FakeData
            var listUsers = new List<DbUsuarioLogin>
            {
                new DbUsuarioLogin {Id=1, Nome="Usuario 1", Login="Usuario1", Senha="senha" }
            };

            var listGrupos = new List<DbUsuarioGrupo>
            {
                new DbUsuarioGrupo {Id=1,  Login="Grupo 1" },
                new DbUsuarioGrupo {Id=2,  Login="Grupo 2" },
            };

            var listLoginGrupo = new List<DbUsuarioLoginGrupo>();

            foreach (var user in listUsers)
            {
                foreach (var group in listGrupos)
                {
                    var link = new DbUsuarioLoginGrupo
                    {
                        FkUsuGrupo = group.Id,
                        FkUsuLogin = user.Id,
                        UsuGrupo = group,
                        UsuLogin = user,
                    };
                    listLoginGrupo.Add(link);
                    group.ListUsers = new List<DbUsuarioLoginGrupo> { link };
                }

                user.ListGrups = listLoginGrupo;

            }

            listGrupos.Add(new DbUsuarioGrupo { Id = 3, Login = "Grupo 3" });

            #endregion

            var context = A.Fake<SysContext>();

            Aef.Configure(context, listUsers);
            Aef.Configure(context, listLoginGrupo);
            Aef.Configure(context, listGrupos);

            var usuarioLogin = new UsuarioLoginRepository(context);
            var usuarioLoginGrupo = new UsuarioLoginGrupoRepository(context);
            var usuarioGrupo = new UsuarioGrupoRepository(context);
            result = new DireitosUnitOfWork(
                         context,
                         e => usuarioLogin,
                         e => usuarioLoginGrupo,
                         e => usuarioGrupo
                 );
            return result;
        }

    }
}
