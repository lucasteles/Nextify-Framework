using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pragma.App.Xml.Models.Anbima4
{
    [XmlType("compromisso")]
    public class Compromisso
    {
        [XmlElementAttribute("dtretorno")]
        public string DtRetorno { get; set; }

        [XmlElementAttribute("puretorno")]
        public decimal PuRetorno { get; set; }

        [XmlElementAttribute("indexadorcomp")]
        public string IndexAdorComp { get; set; }

        [XmlElementAttribute("perindexcomp")]
        public decimal PerIndexComp { get; set; }

        [XmlElementAttribute("txoperacao")]
        public decimal TxOperacao { get; set; }

        [XmlElementAttribute("classecomp")]
        public string ClasseComp { get; set; }
    }
}
