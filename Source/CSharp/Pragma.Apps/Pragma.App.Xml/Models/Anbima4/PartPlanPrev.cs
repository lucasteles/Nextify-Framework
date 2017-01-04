using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pragma.App.Xml.Models.Anbima4
{
    [XmlType("partplanprev")]
    public class PartPlanPrev
    {
        [XmlElementAttribute("cnpb")]
        public string Cnpb { get; set; }

        [XmlElementAttribute("percpart")]
        public decimal PercPart { get; set; }
    }
}
