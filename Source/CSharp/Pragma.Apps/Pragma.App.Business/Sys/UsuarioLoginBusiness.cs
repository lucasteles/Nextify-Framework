using Pragma.App.DAO;
using Pragma.App.Model;
using Pragma.App.Validations;
using Pragma.Business;
using Pragma.Business.Abstraction;
using Pragma.Core;
using Pragma.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pragma.App.Business
{
    public interface IUsuarioLoginBusiness : IBusiness<DbUsuarioLogin>
    {
        Task<IOperationResult> LoginAsync(string login, string password);

        string PasswordEncrypt(string password);
    }
    public class UsuarioLoginBusiness : BaseBusiness<DbUsuarioLogin>, IUsuarioLoginBusiness
    {
        readonly IDireitosUnitOfWork UserUnitOfWork;

        public UsuarioLoginBusiness(IDireitosUnitOfWork UnitOfWork)
            : base(UnitOfWork, null, null)
        {
            UserUnitOfWork = UnitOfWork;
        }
        public async Task<IOperationResult> LoginAsync(string login, string senha)
        {

            if (string.IsNullOrEmpty(login))
                return BadResult(
                    ValidationMessages.CantBeEmpty.SetParams(nameof(login))
               );

            if (string.IsNullOrEmpty(senha))
                return BadResult(
                     ValidationMessages.CantBeEmpty.SetParams(nameof(senha))
                );

            // busca o usuario no banco
            var oListUsu = await UserUnitOfWork
                              .UsuarioLoginGrupo
                              .GetUserAndGroupAsync(login);

            // Usuario não cadastrado
            if (!oListUsu.HasElements())
                return BadResult(Validations.ValidationMessages.UserNotFounded);

            var oUsu = oListUsu.FirstOrDefault()?.UsuLogin;

            var AdmM = oListUsu.Any(i => i.UsuGrupo.AdmMenuSistema == 1);
            var AdmI = oListUsu.Any(i => i.UsuGrupo.AdmInvestimento == 1);
            var AdmA = oListUsu.Any(i => i.UsuGrupo.AdmAprovacao == 1);
            var ListGrupo = oListUsu.Select(i => i.FkUsuGrupo).ToList();

            AppConfiguration.InfoUserCurrent = new SysUser(oUsu.Id, oUsu.Login)
            {
                UserListGrup = ListGrupo,
                UserEmail = oUsu.Email,
                UserAdmAprovacao = AdmA,
                UserAdmMenuSistema = AdmM,
                UserAdmInvestimento = AdmI
            };

            var ASCII = Encoding.Default;
            var PassCurrent = ASCII.GetBytes(oUsu.Senha.Trim());
            var PassDig = Encrypt(senha.ToUpper(), oUsu.Senha.Trim()[0]);

            var Erro = !Enumerable.SequenceEqual(PassCurrent, PassDig);

            // verifica se a senha está correta // seguindo o padrão do Invest sempre maiusculo
            if (Erro)
                return BadResult(Validations.ValidationMessages.UserNotFounded);

            return Ok();
        }
        public string PasswordEncrypt(string password)
        {
            return Encoding.UTF8.GetString(Encrypt(password.ToUpper(), password.Trim()[0]));
        }
        /// <summary>
        /// Criptografa uma string de acordo com uma semente
        /// </summary>
        /// <param name="tStr">String que será criptografada</param>
        /// <param name="tSeed">Semente usada para a criptocrafia</param>
        /// <returns>Retorna a string criptografada</returns>
        private static byte[] Encrypt(string tStr, char tSeed)
        {
            var oRan = new Random();
            int nSeed = 0, nResto;
            // se não tiver usuario logado, cria a semente
            if (tSeed == ' ')
            {
                nSeed = Convert.ToInt32(25 * oRan.NextDouble());
                tSeed = ((char)(64 + nSeed));
            }
            nResto = (tSeed % 10) + 1;

            var Encrypt = new List<byte>();
            Encrypt.Add((byte)tSeed);

            int nPart;
            int nLetter;

            for (int i = 0; i < 30; i++)
            {
                nLetter = 0;
                if (tStr.Length > i)
                    nLetter = Convert.ToChar(tStr.Substring(i, 1));

                nLetter = nLetter + (i + 1) + nResto;
                nPart = ((nLetter % 220) + 14);

                if (nPart == 39)
                    nPart = 5;

                nResto = (nLetter % 32) + 1;

                Encrypt.Add((byte)nPart);
            }
            return Encrypt.ToArray();
        }
    }
}
