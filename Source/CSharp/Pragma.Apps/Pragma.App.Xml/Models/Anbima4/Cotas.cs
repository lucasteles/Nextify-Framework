using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pragma.App.Xml.Models.Anbima4
{
    [XmlType("cotas")]
    public class Cotas
    {
        [XmlElementAttribute("isin")]
        public string Isin { get; set; }

        [XmlElementAttribute("cnpjfundo")]
        public string CnpjFundo { get; set; }

        [XmlElementAttribute("qtdisponivel")]
        public decimal QtDisponivel { get; set; }

        [XmlElementAttribute("qtgarantia")]
        public decimal QtGarantia { get; set; }

        [XmlElementAttribute("puposicao")]
        public decimal PuPosicao { get; set; }

        [XmlElementAttribute("tributos")]
        public decimal Tributos { get; set; }

        [XmlElementAttribute("nivelrsc")]
        public string NivelRsc { get; set; }
    }
}
