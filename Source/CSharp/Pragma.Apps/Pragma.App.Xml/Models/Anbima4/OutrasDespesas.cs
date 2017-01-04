using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pragma.App.Xml.Models.Anbima4
{
    [XmlType("outrasdespesas")]
    public class OutrasDespesas
    {
        [XmlElementAttribute("coddesp")]
        public int CodDesp { get; set; }
        [XmlElementAttribute("valor")]
        public decimal Valor { get; set; }
    }
}
