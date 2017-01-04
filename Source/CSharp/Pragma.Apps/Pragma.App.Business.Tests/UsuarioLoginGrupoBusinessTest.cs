using FakeItEasy;
using Pragma.App.DAO;
using Pragma.App.Model;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Pragma.App.Business.Tests
{
    public class UsuarioLoginGrupoBusinessTest
    {
        readonly IUsuarioLoginBusiness _usuarioLoginBusiness;

        public UsuarioLoginGrupoBusinessTest()
        {

            var uow = A.Fake<IDireitosUnitOfWork>();

            var user = new DbUsuarioLogin { Id = 1, Nome = "usuario 1", Login = "Usuario1", Senha = "senha" };
            var group = new DbUsuarioGrupo { Id = 1, Login = "Grupo 1" };
            var group2 = new DbUsuarioGrupo { Id = 2, Login = "Grupo 2" };

            A.CallTo(() => uow.UsuarioLoginGrupo.GetUserAndGroupAsync("Usuario1"))
                .Returns(new List<DbUsuarioLoginGrupo>
                {
                    new DbUsuarioLoginGrupo { Id=1, FkUsuGrupo = 1, FkUsuLogin =1 , UsuGrupo =group, UsuLogin= user},
                    new DbUsuarioLoginGrupo { Id=2, FkUsuGrupo = 2, FkUsuLogin =1 , UsuGrupo =group2, UsuLogin= user},

                });

            _usuarioLoginBusiness = new UsuarioLoginBusiness(uow);

            user.Senha = _usuarioLoginBusiness.PasswordEncrypt(user.Senha);

        }

        [Fact(DisplayName = "[BIZ] Usuario invalido NÃO deve logar")]
        public async void Should_not_invalid_user_login()
        {
            var result = await _usuarioLoginBusiness.LoginAsync("Usuario_errado", "senha");

            Assert.False(result.Success);

        }

        [Fact(DisplayName = "[BIZ] Usuario valido com senha valida deve logar")]
        public async void Should_valid_user_with_valid_password_login()
        {
            var result = await _usuarioLoginBusiness.LoginAsync("Usuario1", "senha");

            Assert.True(result.Success, result.ErrorList.FirstOrDefault()?.Message);

        }

        [Fact(DisplayName = "[BIZ] Usuario valido com senha INVALIDA NÃO deve logar")]
        public async void Should_not_valid_user_with_invalid_password_login()
        {
            var result = await _usuarioLoginBusiness.LoginAsync("Usuario1", "errada");

            Assert.False(result.Success, result.ErrorList.FirstOrDefault()?.Message);

        }

    }
}
