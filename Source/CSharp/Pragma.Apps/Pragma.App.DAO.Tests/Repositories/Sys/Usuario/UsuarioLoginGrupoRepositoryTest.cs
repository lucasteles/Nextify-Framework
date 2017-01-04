using System.Linq;
using Xunit;

namespace Pragma.App.DAO.Tests.Repositories.Sys.Usuario
{
    public class UsuarioLoginGrupoRepositoryTest
    {
        readonly IDireitosUnitOfWork _userUnitOfWork;

        public UsuarioLoginGrupoRepositoryTest()
        {
            var factory = new FakeUnitOfWorkFactory();

            _userUnitOfWork = FakeUnitOfWorkFactory.GetFakeUserUnitOfWork();
        }

        [Fact(DisplayName = "[DAO] Deve encontrar usuario pelo login")]
        public async void Should_find_user_by_login()
        {
            var user = await _userUnitOfWork.UsuarioLoginGrupo.GetUserAndGroupAsync("Usuario1");
            Assert.True(user.Count() == 2);
        }

        [Fact(DisplayName = "[DAO] NÃO deve encontrar usuario pelo login")]
        public async void Should_not_find_user_by_login()
        {
            var user = await _userUnitOfWork.UsuarioLoginGrupo.GetUserAndGroupAsync("UsuarioNaoExistente");
            Assert.True(user.Count() == 0, "Buscando usuario que nao devia.");
        }
    }
}
