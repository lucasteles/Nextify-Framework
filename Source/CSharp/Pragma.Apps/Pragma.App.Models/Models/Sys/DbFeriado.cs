using Pragma.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUFERIADO")]
    public class DbFeriado : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód.")]
        public int Id { get; set; }

        [Column("DT_FERIADO")]
        [PgmColumn(DisplayText = "Dt. Feriado")]
        public DateTime DtFeriado { get; set; }

        [Column("DS_FERIADO")]
        [PgmColumn(DisplayText = "Feriado")]
        public string Nome { get; set; }

        [Column("TG_PERIODO")]
        [PgmColumn(DisplayText = "Fixo")]
        public int Fixo { get; set; }

        [Column("FK_PAIS")]
        [PgmColumn(DisplayText = "Cód. Pais")]
        public string FkPais { get; set; }
        [ForeignKey(nameof(FkPais))]
        public virtual DbPais Pais { get; set; }

    }
}
