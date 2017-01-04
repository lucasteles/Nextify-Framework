using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pragma.App.Xml.Models.Anbima4
{
    [XmlType("forwardsmoedas")]
    public class ForwardsMoedas
    {
        [XmlElementAttribute("classeoperacao")]
        public string ClasseOperacao { get; set; }

        [XmlElementAttribute("dtvencimento")]
        public string DtVencimento { get; set; }

        [XmlElementAttribute("hedge")]
        public string Hedge { get; set; }

        [XmlElementAttribute("moedaativa")]
        public string MoedaAtiva { get; set; }

        [XmlElementAttribute("moedapassiva")]
        public string MoedaPassiva { get; set; }

        [XmlElementAttribute("notional")]
        public decimal Notional { get; set; }

        [XmlElementAttribute("taxa")]
        public decimal Taxa { get; set; }

        [XmlElementAttribute("tipooperacao")]
        public string tipooperacao { get; set; }

        [XmlElementAttribute("tphedge")]
        public int TpHedge { get; set; }

        [XmlElementAttribute("tributos")]
        public decimal Tributos { get; set; }

        [XmlElementAttribute("valorfinanceiro")]
        public decimal ValorFinanceiro { get; set; }
    }
}
