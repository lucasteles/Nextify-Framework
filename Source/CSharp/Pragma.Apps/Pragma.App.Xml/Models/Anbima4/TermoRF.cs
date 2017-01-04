using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pragma.App.Xml.Models.Anbima4
{
    [XmlType("termorf")]
    public class TermoRF
    {
        [XmlElementAttribute("isin")]
        public string Isin { get; set; }

        [XmlElementAttribute("dtvencativo")]
        public string DtVencativo { get; set; }

        [XmlElementAttribute("dtoper")]
        public string DtOper { get; set; }

        [XmlElementAttribute("dtvencimento")]
        public string DtVencimento { get; set; }

        [XmlElementAttribute("qtd")]
        public decimal Qtd { get; set; }

        [XmlElementAttribute("PuOperacao")]
        public decimal PuOperacao { get; set; }

        [XmlElementAttribute("puvencimento")]
        public decimal PuVencimento { get; set; }

        [XmlElementAttribute("puposicao")]
        public decimal PuPosicao { get; set; }

        [XmlElementAttribute("puemissao")]
        public decimal PuEmissao { get; set; }

        [XmlElementAttribute("principal")]
        public decimal Principal { get; set; }

        [XmlElementAttribute("valorfin")]
        public decimal ValorFin { get; set; }

        [XmlElementAttribute("tributos")]
        public decimal Tributos { get; set; }

        [XmlElementAttribute("coupom")]
        public decimal Coupom { get; set; }

        [XmlElementAttribute("indexador")]
        public string Indexador { get; set; }

        [XmlElementAttribute("percindex")]
        public decimal PercIndex { get; set; }

        [XmlElementAttribute("caracteristica")]
        public string Caracteristica { get; set; }

        [XmlElementAttribute("classeoperacao")]
        public string ClasseOperacao { get; set; }

        [XmlElementAttribute("hedge")]
        public string Hedge { get; set; }

        [XmlElementAttribute("tphedge")]
        public int TpHedge { get; set; }

        [XmlElementAttribute("idinternoativo")]
        public string IdinternoAtivo { get; set; }

        [XmlElementAttribute("nivelrsc")]
        public string Nivelrsc { get; set; }
    }
}
