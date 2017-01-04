using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pragma.App.Xml.Models.Anbima4
{
    [XmlType("corretagem")]
    public class Corretagem
    {
        [XmlElementAttribute("cnpjcorretora")]
        public string CnpjCorretora { get; set; }

        [XmlElementAttribute("tpcorretora")]
        public int TpCorretora { get; set; }

        [XmlElementAttribute("numope")]
        public int NumOpe { get; set; }

        [XmlElementAttribute("vlbov")]
        public decimal VlBov { get; set; }

        [XmlElementAttribute("vlrepassebov")]
        public decimal VlRepasseBov { get; set; }

        [XmlElementAttribute("vlbmf")]
        public decimal Vlbmf { get; set; }

        [XmlElementAttribute("vlrepassebmf")]
        public decimal VlRepassebmf { get; set; }

        [XmlElementAttribute("vloutbolsas")]
        public decimal VlOutbolsas { get; set; }

        [XmlElementAttribute("vlrepasseoutbol")]
        public decimal VlRepasseoutbol { get; set; }
    }
}
