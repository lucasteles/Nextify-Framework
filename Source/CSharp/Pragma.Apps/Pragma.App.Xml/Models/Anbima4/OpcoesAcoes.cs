using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pragma.App.Xml.Models.Anbima4
{
    [XmlType("opcoesacoes")]
    public class OpcoesAcoes
    {
        [XmlElementAttribute("isin")]
        public string Isin { get; set; }

        [XmlElementAttribute("cusip")]
        public string Cusip { get; set; }

        [XmlElementAttribute("codativo")]
        public string Codativo { get; set; }

        [XmlElementAttribute("ativobase")]
        public string AtivoBase { get; set; }

        [XmlElementAttribute("qtdisponivel")]
        public decimal QtDisponivel { get; set; }

        [XmlElementAttribute("valorfinanceiro")]
        public decimal ValorFinanceiro { get; set; }

        [XmlElementAttribute("precoexercicio")]
        public decimal PrecoExercicio { get; set; }

        [XmlElementAttribute("dtvencimento")]
        public string DtVencimento { get; set; }

        [XmlElementAttribute("classeoperacao")]
        public string ClasseOperacao { get; set; }

        [XmlElementAttribute("tributos")]
        public decimal Tributos { get; set; }

        [XmlElementAttribute("puposicao")]
        public decimal PuPosicao { get; set; }

        [XmlElementAttribute("Premio")]
        public decimal Premio { get; set; }

        [XmlElementAttribute("percprovcred")]
        public decimal PercProvcred { get; set; }

        [XmlElementAttribute("tpconta")]
        public int TpConta { get; set; }

        [XmlElementAttribute("hedge")]
        public string Hedge { get; set; }

        [XmlElementAttribute("tphedge")]
        public int TpHedge { get; set; }
    }
}
