using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pragma.App.Xml.Models.Anbima4
{
    [XmlType("acoes")]
    public class Acoes
    {
        [XmlElementAttribute("isin")]
        public string Isin { get; set; }

        [XmlElementAttribute("cusip")]
        public string Cusip { get; set; }

        [XmlElementAttribute("codativo")]
        public string Codativo { get; set; }

        [XmlElementAttribute("qtdisponivel")]
        public decimal QtDisponivel { get; set; }

        [XmlElementAttribute("lote")]
        public int Lote { get; set; }

        [XmlElementAttribute("qtgarantia")]
        public decimal QtGarantia { get; set; }

        [XmlElementAttribute("valorfindisp")]
        public decimal ValorFindisp { get; set; }

        [XmlElementAttribute("valorfinemgar")]
        public decimal ValorFinemgar { get; set; }

        [XmlElementAttribute("tributos")]
        public decimal Tributos { get; set; }

        [XmlElementAttribute("puposicao")]
        public decimal PuPosicao { get; set; }

        [XmlElementAttribute("percprovcred")]
        public decimal PercProvcred { get; set; }

        [XmlElementAttribute("tpconta")]
        public int TpConta { get; set; }

        [XmlElementAttribute("classeoperacao")]
        public string ClasseOperacao { get; set; }

        [XmlElementAttribute("dtvencalug")]
        public string DtVencalug { get; set; }

        [XmlElementAttribute("txalug")]
        public decimal TxAlug { get; set; }

        [XmlElementAttribute("cnpjinter")]
        public string CnpjInter { get; set; }
    }
}
