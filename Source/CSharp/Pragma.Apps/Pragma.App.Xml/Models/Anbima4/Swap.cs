using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pragma.App.Xml.Models.Anbima4
{
    [XmlType("swap")]
    public class Swap
    {
        [XmlElementAttribute("cetipbmf")]
        public string Cetipbmf { get; set; }

        [XmlElementAttribute("isin")]
        public string Isin { get; set; }

        [XmlElementAttribute("dtoperacao")]
        public string DtOperacao { get; set; }

        [XmlElementAttribute("dtregistro")]
        public string DtRegistro { get; set; }

        [XmlElementAttribute("dtvencimento")]
        public string DtVencimento { get; set; }

        [XmlElementAttribute("cnpjcontraparte")]
        public string CnpjContraparte { get; set; }

        [XmlElementAttribute("garantia")]
        public decimal Garantia { get; set; }

        [XmlElementAttribute("vlnotional")]
        public decimal VlNotional { get; set; }

        [XmlElementAttribute("tributos")]
        public decimal Tributos { get; set; }

        [XmlElementAttribute("vlmercadoativo")]
        public decimal VlMercadoativo { get; set; }

        [XmlElementAttribute("taxaativo")]
        public decimal TaxaAtivo { get; set; }

        [XmlElementAttribute("indexadorativo")]
        public string IndexadorAtivo { get; set; }

        [XmlElementAttribute("percindexativo")]
        public decimal PercindexAtivo { get; set; }

        [XmlElementAttribute("vlmercadopassivo")]
        public decimal VlmercadoPassivo { get; set; }

        [XmlElementAttribute("taxapassivo")]
        public decimal TaxaPassivo { get; set; }

        [XmlElementAttribute("indexadorpassivo")]
        public string IndexadorPassivo { get; set; }

        [XmlElementAttribute("percindexpassivo")]
        public string PercindexPassivo { get; set; }

        [XmlElementAttribute("hedge")]
        public string Hedge { get; set; }

        [XmlElementAttribute("tphedge")]
        public int TpHedge { get; set; }

        [XmlElementAttribute("idinternoativo")]
        public string IdinternoAtivo { get; set; }
    }
}
