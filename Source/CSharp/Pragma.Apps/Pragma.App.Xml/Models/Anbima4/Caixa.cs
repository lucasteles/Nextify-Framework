using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pragma.App.Xml.Models.Anbima4
{
    [XmlType("caixa")]
    public class Caixa
    {
        [XmlElementAttribute("isininstituicao")]
        public string IsinInstituicao { get; set; }

        [XmlElementAttribute("tpconta")]
        public string TpConta { get; set; }

        [XmlElementAttribute("saldo")]
        public decimal Saldo { get; set; }

        [XmlElementAttribute("nivelrsc")]
        public string Nivelrsc { get; set; }
    }
}
