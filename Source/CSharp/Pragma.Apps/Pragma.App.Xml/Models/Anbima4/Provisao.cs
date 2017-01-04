using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pragma.App.Xml.Models.Anbima4
{
    [XmlType("provisao")]
    public class Provisao
    {
        [XmlElementAttribute("codprov")]
        public int CodProv { get; set; }
        [XmlElementAttribute("credeb")]
        public string CreDeb { get; set; }
        [XmlElementAttribute("dt")]
        public string Dt { get; set; }
        [XmlElementAttribute("valor")]
        public decimal Valor { get; set; }
    }
}
