using Pragma.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUMANDATOVERSAO")]
    public class DbMandatoVersao : BaseModel, IModelWithKey
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

        [Column("DT_DE")]
        [Range(typeof(DateTime), "1/1/1900", "6/6/2079")]
        public DateTime? DtDe { get; set; }

        [Column("DT_ATE")]
        [Range(typeof(DateTime), "1/1/1900", "6/6/2079")]
        public DateTime? DtAte { get; set; }

    }
}
