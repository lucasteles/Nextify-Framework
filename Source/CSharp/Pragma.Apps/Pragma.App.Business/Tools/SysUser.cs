using System.Collections.Generic;

namespace Pragma.App.Business
{
    public class SysUser
    {
        public SysUser(int usuId, string usuLogin)
        {
            UserId = usuId;
            UserLogin = usuLogin;

            //seta informações necessarias a DAO
            Pragma.DAO.UserData.UserID = usuId;
        }
        /// <summary>
        /// Código do usuario logado
        /// </summary>
        public readonly int UserId;
        /// <summary>
        /// Login do usuario logado
        /// </summary>
        public readonly string UserLogin = string.Empty;
        /// <summary>
        /// Lista de grupos que o usuario está cadastrado
        /// </summary>
        public List<int> UserListGrup;
        /// <summary>
        /// Email do usuario logado
        /// </summary>
        public string UserEmail;
        /// <summary>
        /// Define se o usuário pode visualizar todos os investimentos cadastrados
        /// </summary>
        public bool UserAdmInvestimento;
        /// <summary>
        /// Define se o usuário pode acessar todas as telas do sistema
        /// </summary>
        public bool UserAdmMenuSistema;
        /// <summary>
        /// Define se o usuário pode aprovar qualquer solicitação que precisa de autorização
        /// </summary>
        public bool UserAdmAprovacao;
    }
}

