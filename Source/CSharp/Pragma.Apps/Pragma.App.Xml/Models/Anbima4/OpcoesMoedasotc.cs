using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pragma.App.Xml.Models.Anbima4
{
    [XmlType("opcoesmoedasotc")]
    public class OpcoesMoedasotc
    {
        [XmlElementAttribute("callput")]
        public string CallPut { get; set; }

        [XmlElementAttribute("classeoperacao")]
        public string ClasseOperacao { get; set; }

        [XmlElementAttribute("codoper")]
        public string CodOper { get; set; }

        [XmlElementAttribute("dtexercicio")]
        public string DtExercicio { get; set; }

        [XmlElementAttribute("dtoperacao")]
        public string DtOperacao { get; set; }

        [XmlElementAttribute("dtvencimento")]
        public string DtVencimento { get; set; }

        [XmlElementAttribute("garantia")]
        public string Garantia { get; set; }

        [XmlElementAttribute("hedge")]
        public string Hedge { get; set; }

        [XmlElementAttribute("moedaativa")]
        public string MoedaAtiva { get; set; }

        [XmlElementAttribute("moedapassiva")]
        public string MoedaPassiva { get; set; }

        [XmlElementAttribute("precoexercicio")]
        public decimal PrecoExercicio { get; set; }

        [XmlElementAttribute("premio")]
        public decimal Premio { get; set; }

        [XmlElementAttribute("puposicao")]
        public decimal PuPosicao { get; set; }

        [XmlElementAttribute("quantidade")]
        public decimal Quantidade { get; set; }

        [XmlElementAttribute("tipo")]
        public string Tipo { get; set; }

        [XmlElementAttribute("tphedge")]
        public int TpHedge { get; set; }

        [XmlElementAttribute("tributos")]
        public decimal Tributos { get; set; }

        [XmlElementAttribute("valorfinanceiro")]
        public decimal ValorFinanceiro { get; set; }
    }
}
