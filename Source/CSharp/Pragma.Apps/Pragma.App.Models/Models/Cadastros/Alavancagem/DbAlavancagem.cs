using Pragma.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUALAVANCAGEM")]
    public class DbAlavancagem : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        public int Id { get; set; }

        [Column("DT_INICIO")]
        [PgmColumn(DisplayText = "Dt. Inicio")]
        public DateTime DtInicio { get; set; }

        [Column("DT_FIM")]
        [PgmColumn(DisplayText = "Dt. Fim")]
        public DateTime DtFim { get; set; }

    }
}
