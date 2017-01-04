using System.Collections.Generic;
using System.Xml.Serialization;

namespace Pragma.App.Xml.Models.Anbima4
{
    [XmlRoot(ElementName = "fundo")]
    public class Fundo
    {
        [XmlElement("header")]
        public List<Header> Header { get; set; } = new List<Header>();

        [XmlElement("partplanprev")]
        public List<PartPlanPrev> PartPlanPrev { get; set; } = new List<PartPlanPrev>();

        [XmlElement("titpublico")]
        public List<TitPublico> TitPublico { get; set; } = new List<TitPublico>();

        [XmlElement("titprivado")]
        public List<TitPrivado> TitPrivado { get; set; } = new List<TitPrivado>();

        [XmlElement("debenture")]
        public List<Debenture> Debenture { get; set; } = new List<Debenture>();

        [XmlElement("acoes")]
        public List<Acoes> Acoes { get; set; } = new List<Acoes>();

        [XmlElement("opcoesacoes")]
        public List<OpcoesAcoes> OpcoesAcoes { get; set; } = new List<OpcoesAcoes>();

        [XmlElement("opcoesderiv")]
        public List<OpcoesDeriv> OpcoesDeriv { get; set; } = new List<OpcoesDeriv>();

        [XmlElement("opcoesflx")]
        public List<OpcoesFlx> OpcoesFlx { get; set; } = new List<OpcoesFlx>();

        [XmlElement("termorv")]
        public List<TermoRV> TermoRV { get; set; } = new List<TermoRV>();

        [XmlElement("termorf")]
        public List<TermoRF> TermoRF { get; set; } = new List<TermoRF>();

        [XmlElement("futuros")]
        public List<Futuros> Futuros { get; set; } = new List<Futuros>();

        [XmlElement("swap")]
        public List<Swap> Swap { get; set; } = new List<Swap>();

        [XmlElement("caixa")]
        public List<Caixa> Caixa { get; set; } = new List<Caixa>();

        [XmlElement("cotas")]
        public List<Cotas> Cotas { get; set; } = new List<Cotas>();

        [XmlElement("despesas")]
        public List<Despesas> Despesas { get; set; } = new List<Despesas>();

        [XmlElement("outrasdespesas")]
        public List<OutrasDespesas> OutrasDespesas { get; set; } = new List<OutrasDespesas>();

        [XmlElement("provisao")]
        public List<Provisao> Provisao { get; set; } = new List<Provisao>();

        [XmlElement("corretagem")]
        public List<Corretagem> Corretagem { get; set; } = new List<Corretagem>();

        [XmlElement("imoveis")]
        public List<Imoveis> Imoveis { get; set; } = new List<Imoveis>();

        [XmlElement("opcoesmoedasotc")]
        public List<OpcoesMoedasotc> OpcoesMoedasotc { get; set; } = new List<OpcoesMoedasotc>();

        [XmlElement("forwardsmoedas")]
        public List<ForwardsMoedas> ForwardsMoedas { get; set; } = new List<ForwardsMoedas>();

        [XmlElement("participacoes")]
        public List<Participacoes> Participacoes { get; set; } = new List<Participacoes>();

        [XmlElement("fidc")]
        public List<Fidc> Fidc { get; set; } = new List<Fidc>();
    }
}
