using System.Xml.Serialization;

namespace Pragma.App.Xml.Models.Anbima4
{
    [XmlType("arquivoposicao_4_01")]
    public class XMLAnbima4
    {
        [XmlElement("fundo")]
        public Fundo Fundo { get; set; }

        [XmlElement("carteira")]
        public Carteria Carteira { get; set; }
    }
}
