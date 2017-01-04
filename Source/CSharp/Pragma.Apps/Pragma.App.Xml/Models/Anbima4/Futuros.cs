using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pragma.App.Xml.Models.Anbima4
{
    [XmlType("futuros")]
    public class Futuros
    {
        [XmlElementAttribute("isin")]
        public string Isin { get; set; }

        [XmlElementAttribute("ativo")]
        public string Ativo { get; set; }

        [XmlElementAttribute("cnpjcorretora")]
        public string CnpjCorretora { get; set; }

        [XmlElementAttribute("serie")]
        public string Serie { get; set; }

        [XmlElementAttribute("quantidade")]
        public decimal Quantidade { get; set; }

        [XmlElementAttribute("vltotalpos")]
        public decimal VlTotalpos { get; set; }

        [XmlElementAttribute("tributos")]
        public decimal Tributos { get; set; }

        [XmlElementAttribute("dtvencimento")]
        public string DtVencimento { get; set; }

        [XmlElementAttribute("vlajuste")]
        public decimal VlAjuste { get; set; }

        [XmlElementAttribute("classeoperacao")]
        public string ClasseOperacao { get; set; }

        [XmlElementAttribute("hedge")]
        public string Hedge { get; set; }

        [XmlElementAttribute("tphedge")]
        public int TpHedge { get; set; }
    }
}
