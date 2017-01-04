using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUMANDATOITEM")]
    public class DbMandatoItem : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód.")]
        public int Id { get; set; }

        [Column("FK_MANDATO")]
        [PgmColumn(DisplayText = "Cód Mandato")]
        public string FkMandato { get; set; }
        [ForeignKey(nameof(FkMandato))]
        public virtual DbMandato Mandato { get; set; }

        [Column("NR_VERSAO")]
        [PgmColumn(DisplayText = "Nr. Versão")]
        public int NrVersao { get; set; }

        [Column("FK_SETOR")]
        public int FkSetor { get; set; }
        [ForeignKey(nameof(FkSetor))]
        public virtual DbAtivoClasse Setor { get; set; }

        [Column("VL_MAXIMO")]
        [PgmColumn(DisplayText = "Vl. Maximo")]
        public decimal VlMaximo { get; set; }

        [Column("VL_ESPERADO1")]
        [PgmColumn(DisplayText = "Vl. Minimo")]
        public decimal VlMinimo { get; set; }

        [Column("VL_ESPERADO2")]
        [PgmColumn(DisplayText = "Vl. Neutro")]
        public decimal VlNeutro { get; set; }

        [Column("TG_LOCAL")]
        [PgmColumn(DisplayText = "Local")]
        public decimal TgLocal { get; set; }

    }
}
