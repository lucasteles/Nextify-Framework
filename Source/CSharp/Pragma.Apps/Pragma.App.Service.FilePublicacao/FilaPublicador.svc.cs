using System;
using System.Collections.Generic;
using System.Linq;
using Pragma.Extensions;
using Pragma.App.Business;
using Pragma.App.Service.FilePublicacao.Tools;

namespace Pragma.App.Service.FilePublicacao
{
    public enum Status : int
    {
        Erro = 0,
        Pedido = 1,
        Termino = 2
    }

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class FilaPublicador : IFilaPublicador
    {
        AppConfiguration config { get; set; }
        /// <summary>
        /// Lista de Investimentos que fizeram o pedido para publicar
        /// </summary>
        static volatile Dictionary<string, List<IGuiaInvestimentos>> Pedidos = new Dictionary<string, List<IGuiaInvestimentos>>();
        /// <summary>
        /// Fila de Investimento para serem publicados, separada por nome da base de dados
        /// </summary>
        static volatile Dictionary<string, Queue<IGuiaInvestimentos>> FilaPublicacao = new Dictionary<string, Queue<IGuiaInvestimentos>>();

        /// <summary>
        /// Lista de Investimento que está sendo processados por algum cliente
        /// </summary>
        static volatile Dictionary<string, List<IGuiaInvestimentos>> Processando = new Dictionary<string, List<IGuiaInvestimentos>>();
        /// <summary>
        /// Indica se o Ws já começou a rodar, evitar repetição de configuração inicial
        /// </summary>
        static volatile bool StartWs;

        public static object locker = new object();

        public FilaPublicador()
        {
            lock (locker)
            {
                config.SetConnection("OficialConnection");
                if (!StartWs)
                    Init();
            }
        }

        /// <summary>
        /// Configuração inicial do serviço
        /// </summary>
        public static void Init()
        {
            StartWs = true;
            Startup.Start();
        }

        public string Config(string DataBase)
        {
            DataBase = DataBase.ToUpper();
            if (!FilaPublicacao.ContainsKey(DataBase))
                FilaPublicacao.Add(DataBase, new Queue<IGuiaInvestimentos>());

            if (!Pedidos.ContainsKey(DataBase))
                Pedidos.Add(DataBase, new List<IGuiaInvestimentos>());

            if (!Processando.ContainsKey(DataBase))
                Processando.Add(DataBase, new List<IGuiaInvestimentos>());

            return DataBase;
        }

        public string PedidoPublicacao(int tId, int tUser, string DataBase, string tMachineName, int tStatus, string tMsgErro)
        {
            var eStatus = (Status)tStatus;
            var oInv = DI.Container.Resolve<IGuiaInvestimentos>(); // new GuiaInvestimentos();
            oInv.SetUserById(tUser);
            oInv.SetUserMachine(tMachineName);

            DataBase = Config(DataBase);
            oInv.DataBase = DataBase;

            switch (eStatus)
            {
                case Status.Erro:
                    Processando[DataBase][tId].FinishErro(tMsgErro);

                    break;
                case Status.Pedido:
                    oInv.Msg = "Fila Vazia!";

                    if (FilaPublicacao[DataBase].Count > 0)
                    {
                        oInv = FilaPublicacao[DataBase].Dequeue();
                        oInv.SetUserById(tUser);
                        oInv.SetUserMachine(tMachineName);
                        tId = Processando[DataBase].Count;

                        oInv.Start(tId);

                        Processando[DataBase].Add(oInv);
                    }
                    else
                    {
                        // verifica se já existe na lista de pedidos
                        var Ped = Pedidos[DataBase].Find(
                                i => i.Machine == oInv.Machine
                                && i.User.Id == oInv.User.Id
                                && i.DataBase == oInv.DataBase);

                        // se existir, selecina para fazer a contagem
                        if (Ped != null)
                        {
                            Ped.Pedido();
                        }
                        else
                        {
                            // faz a contagem e adiciona na lista
                            oInv.Pedido();
                            Pedidos[DataBase].Add(oInv);
                        }

                        return oInv.ClassXml();
                    }
                    break;
                case Status.Termino:
                    oInv.Msg = "Nada para Processar!";
                    // se a lista estiver vazia
                    if (Processando[DataBase].Count == 0)
                        return oInv.ClassXml();
                    // se o indice passado já estiver concluido
                    if (Processando[DataBase][tId].Concluido)
                        return oInv.ClassXml();
                    // verifica se o mesmo usuario que pediu é o que quer finalizar
                    if (Processando[DataBase][tId].User.Id == tUser)
                        Processando[DataBase][tId].Finish();

                    break;
                default:
                    break;
            }

            return Processando[DataBase][tId].FiltroXml();
        }

        public string RecebeListaFilaXml(string tXML)
        {
            var Inv = tXML.StrExtract("<Inv>", "</Inv>");
            var dDe = Convert.ToDateTime(tXML.StrExtract("<DtDe>", "</DtDe>"));
            var dAte = Convert.ToDateTime(tXML.StrExtract("<DtAte>", "</DtAte>"));
            var DataBase = tXML.StrExtract("<DataBase>", "</DataBase>");

            DataBase = Config(DataBase);

            var guia = DI.Container.Resolve<IGuiaInvestimentos>();
            guia.Filtro = new FiltroInvestimento
            {
                Investimento = Inv,
                DtDe = dDe,
                DtAte = dAte,
                DataBase = DataBase
            };

            FilaPublicacao[DataBase].Enqueue(guia);

            return "<Msg>Incluído!</Msg>";
        }

        public bool RecebeListaFila(FiltroInvestimento[] tFila)
        {
            foreach (FiltroInvestimento item in tFila)
            {
                item.DataBase = Config(item.DataBase);
                var guia = DI.Container.Resolve<IGuiaInvestimentos>();
                guia.Filtro = item;

                FilaPublicacao[item.DataBase].Enqueue(guia);
            }
            return true;
        }

        public GuiaInvestimentos[] EnviarListaProcessamento(string DataBase)
        {
            DataBase = Config(DataBase);
            return (GuiaInvestimentos[])Processando[DataBase].OrderByDescending(i => i.Id).ToArray();
        }

        public GuiaInvestimentos[] EnviarFila(string DataBase)
        {
            DataBase = Config(DataBase);
            return (GuiaInvestimentos[])FilaPublicacao[DataBase].ToArray();
        }

        public GuiaInvestimentos[] EnviarListaPedidos(string DataBase)
        {
            DataBase = Config(DataBase);
            return (GuiaInvestimentos[])Pedidos[DataBase].ToArray();
        }

        public bool LimparFila(string DataBase)
        {
            DataBase = Config(DataBase);
            FilaPublicacao[DataBase].Clear();

            return true;
        }
    }

}
