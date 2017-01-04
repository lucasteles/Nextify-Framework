using Pragma.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUCONTROLE")]
    public class DbControle : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        public int Id { get; set; }

        [Column("DS_USUGALGO")]
        [PgmColumn(DisplayText = "Usuário Galgo")]
        public string UsuGalgo { get; set; }

        [Column("DS_PASSGALGO")]
        [PgmColumn(DisplayText = "Senha Galgo")]
        public string PassGalgo { get; set; }

        [Column("DS_USUXMLPCITAU ")]
        [PgmColumn(DisplayText = "Usuário Itau Pc")]
        public string UsuItauPc { get; set; }

        [Column("DS_PASSXMLPCITAU")]
        [PgmColumn(DisplayText = "Senha Itau Pc")]
        public string PassItauPc { get; set; }

        [Column("DS_MSGSENDERGALGO")]
        [PgmColumn(DisplayText = "MsgSender Galgo")]
        public string MsgSenderGalgo { get; set; }

        [Column("DS_URLGALGO")]
        [PgmColumn(DisplayText = "Url Galgo")]
        public string UrlGalgo { get; set; }

        [Column("DS_NOMEVPNGALGO")]
        [PgmColumn(DisplayText = "Nome da VPN do Galgo")]
        public string NomeVPNGalgo { get; set; }

        [Column("DS_USUVPNGALGO")]
        [PgmColumn(DisplayText = "Usuário da VPN do Galgo")]
        public string UsuVPNGalgo { get; set; }

        [Column("DS_PASSVPNGALGO")]
        [PgmColumn(DisplayText = "Senha da VPN do Galgo")]
        public string PassVPNGalgo { get; set; }

        [Column("DH_ULTCONSULTAGALGO")]
        [Range(typeof(DateTime), "1/1/1900", "6/6/2079")]
        [PgmColumn(DisplayText = "Ult. Consulta Galgo")]
        public DateTime? LastConsultGalgo { get; set; }

        [Column("NR_NIVELPADRAO")]
        [PgmColumn(DisplayText = "Nível padrão")]
        public int NrNivelPadrao { get; set; }

    }
}
