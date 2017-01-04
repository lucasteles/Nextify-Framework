using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pragma.App.Xml.Models.Anbima4
{
    [XmlType("imoveis")]
    public class Imoveis
    {
        [XmlElementAttribute("aluguelatrasado")]
        public decimal AluguelAtrasado { get; set; }

        [XmlElementAttribute("aluguelcontratado")]
        public decimal AluguelContratado { get; set; }

        [XmlElementAttribute("cep")]
        public string Cep { get; set; }

        [XmlElementAttribute("cidade")]
        public string Cidade { get; set; }

        [XmlElementAttribute("cnpjcpfavaliador")]
        public string CnpjcpfAvaliador { get; set; }

        [XmlElementAttribute("cnpjemp")]
        public string Cnpjemp { get; set; }

        [XmlElementAttribute("dtavaliacao")]
        public string DtaValiacao { get; set; }

        [XmlElementAttribute("dtopcaorecompra")]
        public string DtOpcaoreCompra { get; set; }

        [XmlElementAttribute("estado")]
        public string Estado { get; set; }

        [XmlElementAttribute("justificativa")]
        public decimal Justificativa { get; set; }

        [XmlElementAttribute("logradouro")]
        public string Logradouro { get; set; }

        [XmlElementAttribute("matricula")]
        public decimal Matricula { get; set; }

        [XmlElementAttribute("motivoquestjur")]
        public string MotivoQuestJur { get; set; }

        [XmlElementAttribute("numero")]
        public string Numero { get; set; }

        [XmlElementAttribute("opcaorecompra")]
        public string OpcaoreCompra { get; set; }

        [XmlElementAttribute("percpart")]
        public decimal PercPart { get; set; }

        [XmlElementAttribute("questjur")]
        public string QuestJur { get; set; }

        [XmlElementAttribute("tipoimovel")]
        public decimal TipoImovel { get; set; }

        [XmlElementAttribute("tipouso")]
        public decimal Tipouso { get; set; }

        [XmlElementAttribute("tpavaliador")]
        public string TpaValiador { get; set; }

        [XmlElementAttribute("valoravaliacao")]
        public decimal ValoraValiacao { get; set; }

        [XmlElementAttribute("valorcontabil")]
        public decimal ValorContabil { get; set; }
    }
}
