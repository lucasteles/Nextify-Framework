using Anbima.Galgo.Binding;
using Galgo.ServicePLCota;
using Pragma.App.Business;
using Pragma.App.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;

namespace Pragma.App.Service.Galgo
{
    public class GalgoWs
    {
        #region Propriedades
        MessageRetornoPLCotaComplexType MsgReturn = new MessageRetornoPLCotaComplexType();
        int Count;//numero de registros retornados

#pragma warning disable CS0649
        int MaxCount; // numero maximo de registros para o retorno

        int CdSti; // código do fundo para a consulta
#pragma warning restore CS0649

        DateTime From, To; // data do periodo da consulta
        string MsgErro; // msg de erro do webserve
        DbControle oCon = new DbControle();
        readonly ISysBusiness SysBusiness;
        readonly IGalgoLogBusiness GalgoLogBusiness;
        #endregion

        #region Contrutores
        public GalgoWs(ISysBusiness sysBusiness, IGalgoLogBusiness galgoLogBusiness)
        {
            SysBusiness = sysBusiness;
            GalgoLogBusiness = galgoLogBusiness;
            // carrega as configurações de controle cadastradas no invest
            oCon = SysBusiness.Get(1);
        }
        #endregion

        #region Metodos
        public void ConnectVPN()
        {
            // abre a conexão com a VPN
            using (var oP = new Process())
            {
                var oInfo = new ProcessStartInfo
                {
                    WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                    FileName = "rasdial.exe",
                    Arguments = "\"VPN Galgo\" \"" + oCon.UsuVPNGalgo.Trim() + "\" \"" + oCon.PassVPNGalgo.Trim() + "\""
                };
                oP.StartInfo = oInfo;
                oP.Start();
                oP.WaitForExit();
                GravarLog("VPN", 0);
            }
        }
        public static void DisconnectVPN()
        {
            // desconecta da VPN
            using (var oP = new Process())
            {
                var oInfo = new ProcessStartInfo
                {
                    WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                    FileName = "rasdial.exe",
                    Arguments = "\"VPN Galgo\" /disconnect"
                };
                oP.StartInfo = oInfo;
                oP.Start();
            }
        }

        public void GravarLog(string tAcao, int tReg)
        {
            var oLog = new DbGalgoLog
            {
                DtInicio = From,
                DtFinal = To,
                Acao = tAcao,
                NrReg = tReg
            };
            GalgoLogBusiness.Add(oLog);
        }

        public void RegisterConsult()
        {
            // atualiza na tclucontrole a ultima consulta do galgo
            oCon.LastConsultGalgo = To;
            SysBusiness.Update(oCon);
        }

        public string GetMsgErro()
        {
            return MsgErro;
        }

        public DateTime LastConsult()
        {
            // recarrega a data da ultima consulta
            oCon = SysBusiness.Get(1);
            return Convert.ToDateTime(oCon.LastConsultGalgo);
        }
        public MessageRetornoPLCotaComplexType GetReturn()
        {
            return MsgReturn;
        }
        public List<DbGalgo> GetList(MessageRetornoPLCotaComplexType tMsg)
        {
            MsgReturn = tMsg;
            return GetList();
        }
        public List<DbGalgo> GetList()
        {
            var Return = new List<DbGalgo>();

            if (MsgReturn.PricRptV04 != null)
            {
                foreach (PriceValuation3 oItem in MsgReturn.PricRptV04.PricValtnDtls)
                {
                    var g = new DbGalgo
                    {
                        DtImportacao = MsgReturn.PricRptV04.MsgId.CreDtTm,
                        FundoRazao = oItem.FinInstrmDtls.Nm,
                        DtConsulta = oItem.ValtnDtTm.Item,
                        DtFundo = oItem.NAVDtTm.Item,
                        NmAdministrator = oItem.FndMgmtCpny.Item.GetType().GetProperty("Nm").GetValue(oItem.FndMgmtCpny.Item).ToString(),

                        StiFundo = Convert.ToInt32(oItem.FinInstrmDtls.Id[0].Item.GetType().GetProperty("Id").GetValue(oItem.FinInstrmDtls.Id[0].Item)),
                        NmFundo = oItem.Id,
                        VlPatrimonio = oItem.TtlNAV[0].Value,
                        VlCota = oItem.NAV[0].Unit,
                        CodValidacao = oItem.ValtnTp.ToString(),
                        Oficial = oItem.OffclValtnInd ? 1 : 0,
                        ClassesUSP = oItem.SspdInd ? 1 : 0,
                        Observacao = ""
                    };
                    if (oItem.AddtlInf != null)
                    {
                        var builder = new System.Text.StringBuilder();
                        builder.Append(g.Observacao);
                        // AddtlInf é uma lista de string, mas no banco é gravado como um campo text
                        foreach (string oS in oItem.AddtlInf)
                        {
                            builder.Append(oS + (char)13);
                        }
                        g.Observacao = builder.ToString();
                    }

                    Return.Add(g);
                }
                // guarda a menor e maior data que retornou do websevice
                // o webservice do galgo é outro fuso horario
                From = ((DateTime)Return.Min(i => i.DtConsulta));
                To = ((DateTime)Return.Max(i => i.DtConsulta));

                // converte o fuso horario para o brasileiro
                var oKstZone = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time"); // Brasilia/BRA
                From = TimeZoneInfo.ConvertTimeFromUtc(From, oKstZone);
                To = TimeZoneInfo.ConvertTimeFromUtc(To, oKstZone);
            }
            return (Return);
        }

        public void SetInterval(object tFrom, object tTo)
        {
            From = Convert.ToDateTime(tFrom);
            To = Convert.ToDateTime(tTo);
        }

        public void SetInterval(DateTime tFrom, DateTime tTo)
        {
            From = tFrom;
            To = tTo;
        }

        public void Consume()
        {
            MsgErro = "";
            ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, errors) => true;
            //Criação do tipo de dados do proxy utilizado como argumento e retorno
            var objIn = new MessageConsultaPLCotaComplexType();
            var objOut = new MessageRetornoPLCotaComplexType();

            try
            {
                using (ServicePLCotaClient objWCF = new ServicePLCotaClient())
                {
                    var GalgoBind = new GalgoBinding();

                    objWCF.Endpoint.Binding = GalgoBind;

                    // Alterando o comprtamento default do .NET - assinar e criptografar - para apenas assinar.
                    objWCF.Endpoint.Contract.ProtectionLevel = System.Net.Security.ProtectionLevel.Sign;

                    //Passa as credenciais de produção para o proxy
                    objWCF.ClientCredentials.UserName.UserName = oCon.UsuGalgo.Trim();
                    objWCF.ClientCredentials.UserName.Password = oCon.PassGalgo.Trim();

                    objIn.idMsgSender = oCon.MsgSenderGalgo.Trim();

                    // se tiver define numero maximo de registros
                    if (MaxCount != 0)
                    {
                        objIn.qtMaxElementSpecified = true;
                        objIn.qtMaxElement = MaxCount;
                    }
                    // DtInicInfoSpecified = true,DtFinInfoSpecified = true,
                    // define os parametros
                    var Parametros = new ParametrosPLCotaComplexType
                    {
                        DtInicEnvioCota = From.ToString("s"),
                        DtFinEnvioCota = To.ToString("s"),
                        PgNb = 1
                    };

                    // se o Sti estiver define adicionar aos parametros
                    if (CdSti != 0)
                    {
                        var Item = new BuscaObjetoComplexType
                        {
                            Objeto = new ObjetoComplexType[]
                                {
                                  new ObjetoComplexType
                                    {

                                        CdSti = CdSti
                                    }
                                }
                        };
                        Parametros.Item = Item;
                    }
                    objIn.Parametros = Parametros;

                    // Chama o webservice
                    objOut = objWCF.Consumir(objIn);
                    // fecha a conexão
                    objWCF.Close();
                    GravarLog("RET", objOut.qtElementCount);
                }
            }
            catch (Exception ex)
            {
                MsgErro = ex.Message;
                if (ex.InnerException != null && ex.InnerException.Message != null)
                {
                    var cMsg = ex.InnerException.Message;
                    if ("PC.0137".Equals(cMsg))
                        MsgErro = "Não existe registros para esse periodo!";
                }
            }

            Count = objOut.qtElementCount;
            MsgReturn = objOut;
        }
        #endregion
    }
}