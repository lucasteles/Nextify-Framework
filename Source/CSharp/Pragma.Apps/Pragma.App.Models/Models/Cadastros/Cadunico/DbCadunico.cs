using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUCADUNICO")]
    public class DbCadunico : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód.")]
        public int Id { get; set; }

        [Column("TG_PESSOA")]
        [PgmColumn(DisplayText = "Pessoa")]
        public string TgPessoa { get; set; }

        [Column("TG_TIPOFUNDO")]
        [PgmColumn(DisplayText = "Tipo de Fundo")]
        public char TgTipofundo { get; set; }

        [Column("FK_TIPO")]
        [PgmColumn(DisplayText = "Cód. Tipo")]
        public byte FkTipo { get; set; }

        [Column("NR_CNPJ")]
        [PgmColumn(DisplayText = "Nr. CNPJ")]
        public decimal NrCnpj { get; set; }

        [Column("DS_FANTASIA")]
        [PgmColumn(DisplayText = "Fantasia")]
        public string Fantasia { get; set; }

        [Column("DS_RAZAO")]
        [PgmColumn(DisplayText = "Razão")]
        public string Razao { get; set; }

        /// <summary>
        /// Corresponde ao Administrador (no caso de Fundos)
        /// </summary>
        [Column("FK_INSTITUICAO")]
        [PgmColumn(DisplayText = "Cód Instituicao")]
        public int FkInstituicao { get; set; }

    }
}