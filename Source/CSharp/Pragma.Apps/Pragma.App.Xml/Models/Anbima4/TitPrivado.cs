using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pragma.App.Xml.Models.Anbima4
{
    [XmlType("titprivado")]
    public class TitPrivado : TitPublico
    {
        [XmlElementAttribute("cnpjemissor")]
        public string CnpjEmissor { get; set; }
    }
}
