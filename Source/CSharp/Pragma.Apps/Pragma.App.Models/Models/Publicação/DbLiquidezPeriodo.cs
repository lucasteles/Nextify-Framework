using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using Pragma.Core;

namespace Pragma.App.Model
{
    [Table("TCLULIQUIDEZPERIODO")]
    public class DbLiquidezPeriodo : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        public int Id { get; set; }

        [Column("NR_DIAS")]
        [PgmColumn(DisplayText = "Nr. Dias")]
        public int NrDias { get; set; }

    }
}
