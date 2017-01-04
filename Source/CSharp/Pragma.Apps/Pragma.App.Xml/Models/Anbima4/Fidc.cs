using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pragma.App.Xml.Models.Anbima4
{
    [XmlType("fidc")]
    public class Fidc
    {
        [XmlElementAttribute("valorfinanceiro")]
        public decimal ValorFinanceiro { get; set; }
    }
}
