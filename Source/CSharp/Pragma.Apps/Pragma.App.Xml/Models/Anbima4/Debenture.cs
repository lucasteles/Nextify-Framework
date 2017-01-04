using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pragma.App.Xml.Models.Anbima4
{
    [XmlType("debenture")]
    public class Debenture
    {
        [XmlElementAttribute("isin")]
        public string Isin { get; set; }

        [XmlElementAttribute("coddeb")]
        public string Coddeb { get; set; }

        [XmlElementAttribute("debconv")]
        public string Debconv { get; set; }

        [XmlElementAttribute("debpartlucro")]
        public string DebpartLucro { get; set; }

        [XmlElementAttribute("SPE")]
        public string SPE { get; set; }

        [XmlElementAttribute("cusip")]
        public string Cusip { get; set; }

        [XmlElementAttribute("dtemissao")]
        public string DtEmissao { get; set; }

        [XmlElementAttribute("dtoperacao")]
        public string DtOperacao { get; set; }

        [XmlElementAttribute("dtvencimento")]
        public string DtVencimento { get; set; }

        [XmlElementAttribute("cnpjemissor")]
        public string CnpjEmissor { get; set; }

        [XmlElementAttribute("qtdisponivel")]
        public decimal QtDisponivel { get; set; }

        [XmlElementAttribute("qtgarantia")]
        public decimal QtGarantia { get; set; }

        [XmlElementAttribute("depgar")]
        public int Depgar { get; set; }

        [XmlElementAttribute("pucompra")]
        public decimal PuCompra { get; set; }

        [XmlElementAttribute("puvencimento")]
        public decimal PuVencimento { get; set; }

        [XmlElementAttribute("puposicao")]
        public decimal PuPosicao { get; set; }

        [XmlElementAttribute("puemissao")]
        public decimal PuEmissao { get; set; }

        [XmlElementAttribute("principal")]
        public decimal Principal { get; set; }

        [XmlElementAttribute("tributos")]
        public decimal Tributos { get; set; }

        [XmlElementAttribute("valorfindisp")]
        public decimal ValorFinDisp { get; set; }

        [XmlElementAttribute("valorfinemgar")]
        public decimal ValorFinEmgar { get; set; }

        [XmlElementAttribute("coupom")]
        public decimal Coupom { get; set; }

        [XmlElementAttribute("indexador")]
        public string Indexador { get; set; }

        [XmlElementAttribute("percindex")]
        public decimal PercIndex { get; set; }

        [XmlElementAttribute("caracteristica")]
        public string Caracteristica { get; set; }

        [XmlElementAttribute("percprovcred")]
        public decimal PercProvcred { get; set; }

        [XmlElementAttribute("compromisso")]
        public List<Compromisso> Compromisso { get; set; }

        [XmlElementAttribute("classeoperacao")]
        public string ClasseOperacao { get; set; }

        [XmlElementAttribute("idinternoativo")]
        public string IdInternoAtivo { get; set; }

        [XmlElementAttribute("nivelrsc")]
        public string NivelRsc { get; set; }
    }
}
