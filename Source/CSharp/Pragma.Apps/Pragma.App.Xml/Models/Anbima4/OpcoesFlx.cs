using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pragma.App.Xml.Models.Anbima4
{
    [XmlType("opcoesflx")]
    public class OpcoesFlx
    {
        [XmlElementAttribute("isin")]
        public string Isin { get; set; }

        [XmlElementAttribute("tipo")]
        public string Tipo { get; set; }

        [XmlElementAttribute("callput")]
        public string CallPut { get; set; }

        [XmlElementAttribute("dtoperacao")]
        public string DtOperacao { get; set; }

        [XmlElementAttribute("dtexercicio")]
        public string DtExercicio { get; set; }

        [XmlElementAttribute("ativo")]
        public string Ativo { get; set; }

        [XmlElementAttribute("garantia")]
        public string Garantia { get; set; }

        [XmlElementAttribute("Premio")]
        public decimal Premio { get; set; }

        [XmlElementAttribute("puposicao")]
        public decimal PuPosicao { get; set; }

        [XmlElementAttribute("quantidade")]
        public decimal Quantidade { get; set; }

        [XmlElementAttribute("valorfinanceiro")]
        public decimal ValorFinanceiro { get; set; }

        [XmlElementAttribute("tributos")]
        public decimal Tributos { get; set; }

        [XmlElementAttribute("precoexercicio")]
        public decimal PrecoExercicio { get; set; }

        [XmlElementAttribute("classeoperacao")]
        public string ClasseOperacao { get; set; }

        [XmlElementAttribute("hedge")]
        public string Hedge { get; set; }

        [XmlElementAttribute("tphedge")]
        public int TpHedge { get; set; }
    }
}
