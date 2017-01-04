using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pragma.App.Xml.Models.Anbima4
{
    [XmlType("opcoesderiv")]
    public class OpcoesDeriv
    {
        [XmlElementAttribute("isin")]
        public string Isin { get; set; }

        [XmlElementAttribute("mercado")]
        public int Mercado { get; set; }

        [XmlElementAttribute("ativo")]
        public string Ativo { get; set; }

        [XmlElementAttribute("serie")]
        public string Serie { get; set; }

        [XmlElementAttribute("callput")]
        public string CallPut { get; set; }

        [XmlElementAttribute("quantidade")]
        public decimal Quantidade { get; set; }

        [XmlElementAttribute("valorfinanceiro")]
        public decimal ValorFinanceiro { get; set; }

        [XmlElementAttribute("tributos")]
        public decimal Tributos { get; set; }

        [XmlElementAttribute("precoexercicio")]
        public decimal PrecoExercicio { get; set; }

        [XmlElementAttribute("classeoperacao")]
        public string ClasseOperacao { get; set; }

        [XmlElementAttribute("puposicao")]
        public decimal PuPosicao { get; set; }

        [XmlElementAttribute("hedge")]
        public string Hedge { get; set; }

        [XmlElementAttribute("tphedge")]
        public int TpHedge { get; set; }
    }
}
