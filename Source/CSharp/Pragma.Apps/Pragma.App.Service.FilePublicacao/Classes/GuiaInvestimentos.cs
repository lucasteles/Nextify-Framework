using System;
using PGM.Xml;
using Pragma.App.Model;
using Pragma.App.Business;

namespace Pragma.App.Service.FilePublicacao
{
    public interface IGuiaInvestimentos
    {
        int Id { get; set; }
        FiltroInvestimento Filtro { get; set; }
        string Machine { get; set; }
        string DataBase { get; set; }
        string Msg { get; set; }
        DbUsuarioLogin User { get; set; }
        bool Concluido { get; set; }
        void SetUserById(int tIdUser);
        void SetUserMachine(string tMachineName);
        void Start(int tId);
        void Finish();
        void Pedido();
        void FinishErro(string tErro);
        string ClassXml();
        string FiltroXml();
    }

    public class GuiaInvestimentos : IGuiaInvestimentos
    {
        public int Id { get; set; }
        public string Msg { get; set; }
        public FiltroInvestimento Filtro { get; set; }
        public bool Concluido { get; set; }
        public bool Erro { get; set; }
        public bool Expirou { get; set; }
        public DateTime TimeProcessInit { get; set; }
        public DateTime TimeProcessFin { get; set; }
        public string Machine { get; set; }
        public string DataBase { get; set; }
        public DbUsuarioLogin User { get; set; }
        public int NumPedidos { get; set; }
        public DateTime UltPedido { get; set; }
        IUsuarioLoginBusiness UsuarioLogin { get; set; }
        public GuiaInvestimentos(IUsuarioLoginBusiness usuarioLogin)
        {
            UsuarioLogin = usuarioLogin;
        }

        public void Pedido()
        {
            NumPedidos++;
            UltPedido = DateTime.Now;
        }

        public void Start(int tId)
        {
            Id = tId;
            Filtro.Id = tId;
            TimeProcessInit = DateTime.Now;
        }

        public void Finish()
        {
            Erro = false;
            Concluido = true;
            TimeProcessFin = DateTime.Now;
            Msg = "Concluido!";
        }

        public void FinishErro(string tErro)
        {
            Erro = true;
            Msg = tErro;
            Concluido = false;
            TimeProcessFin = DateTime.Now;
        }

        public double Time()
        {
            var Span = TimeProcessFin - TimeProcessInit;
            return Span.TotalSeconds;
        }

        public void SetUserById(int tIdUser)
        {
            User = UsuarioLogin.Get(tIdUser);
        }

        public void SetUserMachine(string tMachineName)
        {
            Machine = tMachineName;
        }

        public string ClassXml()
        {
            return XmlTool.Serialize2String(this);
        }

        public string FiltroXml()
        {
            return XmlTool.Serialize2String(Filtro);
        }
    }
}