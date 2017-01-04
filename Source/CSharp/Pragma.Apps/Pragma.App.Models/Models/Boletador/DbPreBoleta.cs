using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUPREBOLETA")]
    public class DbPreBoleta : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        public int Id { get; set; }

        [Column("FK_PREBOLETAVERSAO")]
        [PgmColumn(DisplayText = "Cód. Versão")]
        public int FkPreBoletaVersao { get; set; }
        [ForeignKey(nameof(FkPreBoletaVersao))]
        public virtual DbPreBoletaVersao PreBoletaVersao { get; set; }

    }
}
