using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pragma.App.Xml.Models.Anbima4
{
    [XmlType("despesas")]
    public class Despesas
    {
        [XmlElementAttribute("txadm")]
        public decimal TxAdm { get; set; }

        [XmlElementAttribute("tributos")]
        public decimal Tributos { get; set; }

        [XmlElementAttribute("perctaxaadm")]
        public decimal PercTaxaAdm { get; set; }

        [XmlElementAttribute("txperf")]
        public string TxPerf { get; set; }

        [XmlElementAttribute("vltxperf")]
        public decimal VltxPerf { get; set; }

        [XmlElementAttribute("perctxperf")]
        public decimal PercTxPerf { get; set; }

        [XmlElementAttribute("percindex")]
        public decimal PercIndex { get; set; }

        [XmlElementAttribute("outtax")]
        public decimal OutTax { get; set; }

        [XmlElementAttribute("indexador")]
        public string Indexador { get; set; }
    }
}
