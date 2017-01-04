using System.Xml.Serialization;

namespace Pragma.App.Xml.Models.Anbima4
{
    [XmlType("header")]
    public class Header
    {
        [XmlElementAttribute("isin")]
        public string Isin { get; set; }
        [XmlElementAttribute("cnpj")]
        public string Cnpj { get; set; }
        [XmlElementAttribute("nome")]
        public string Nome { get; set; }
        [XmlElementAttribute("dtposicao")]
        public string DtPosicao { get; set; }
        [XmlElementAttribute("nomeadm")]
        public string NomeAdm { get; set; }
        [XmlElementAttribute("cnpjadm")]
        public string CnpjAdm { get; set; }
        [XmlElementAttribute("nomegestor")]
        public string NomeGestor { get; set; }
        [XmlElementAttribute("cnpjgestor")]
        public string CnpjGestor { get; set; }
        [XmlElementAttribute("nomecustodiante")]
        public string NomeCustodiante { get; set; }
        [XmlElementAttribute("cnpjcustodiante")]
        public string CnpjCustodiante { get; set; }
        [XmlElementAttribute("valorcota")]
        public decimal ValorCota { get; set; }
        [XmlElementAttribute("quantidade")]
        public decimal Quantidade { get; set; }
        [XmlElementAttribute("patliq")]
        public decimal PatLiq { get; set; }
        [XmlElementAttribute("valorativos")]
        public decimal ValorAtivos { get; set; }
        [XmlElementAttribute("valorreceber")]
        public decimal ValorReceber { get; set; }
        [XmlElementAttribute("valorpagar")]
        public decimal ValorPagar { get; set; }
        [XmlElementAttribute("vlcotasemitir")]
        public decimal VlCotasEmitir { get; set; }
        [XmlElementAttribute("vlcotasresgatar")]
        public decimal VlCotasResgatar { get; set; }
        [XmlElementAttribute("codanbid")]
        public int CodAnbid { get; set; }
        [XmlElementAttribute("tipofundo")]
        public int? TipoFundo { get; set; }
        [XmlElementAttribute("nivelrsc")]
        public string NivelRsc { get; set; }

        [XmlElementAttribute("cnpjcpf")]
        public decimal CnpjCpf { get; set; }
        [XmlElementAttribute("codcart")]
        public string CodCart { get; set; }
        [XmlElementAttribute("tpcli")]
        public string Tpcli { get; set; }
        [XmlElementAttribute("codcntcor")]
        public decimal CodCntcor { get; set; }
        [XmlElementAttribute("tributos")]
        public decimal Tributos { get; set; }
    }
}
