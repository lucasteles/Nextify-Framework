using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pragma.App.Xml.Models.Anbima4
{
    [XmlType("termorv")]
    public class TermoRV
    {
        [XmlElementAttribute("isin")]
        public string Isin { get; set; }

        [XmlElementAttribute("cusip")]
        public string Cusip { get; set; }

        [XmlElementAttribute("ativo")]
        public string Ativo { get; set; }

        [XmlElementAttribute("dtoperacao")]
        public string DtOperacao { get; set; }

        [XmlElementAttribute("dtvencimento")]
        public string DtVencimento { get; set; }

        [XmlElementAttribute("garantia")]
        public decimal Garantia { get; set; }

        [XmlElementAttribute("puposicao")]
        public decimal PuPosicao { get; set; }

        [XmlElementAttribute("quantidade")]
        public decimal Quantidade { get; set; }
        
        [XmlElementAttribute("valorfinanceiro")]
        public decimal ValorFinanceiro { get; set; }

        [XmlElementAttribute("tributos")]
        public decimal Tributos { get; set; }

        [XmlElementAttribute("puvenc")]
        public decimal PuVenc { get; set; }

        [XmlElementAttribute("tpconta")]
        public int TpConta { get; set; }

        [XmlElementAttribute("classeoperacao")]
        public string ClasseOperacao { get; set; }

        [XmlElementAttribute("hedge")]
        public string Hedge { get; set; }

        [XmlElementAttribute("tphedge")]
        public int TpHedge { get; set; }
    }
}
