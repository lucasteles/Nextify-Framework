using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUMOEDAINDICE")]
    public class DbMoedaIndice : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        public int Id { get; set; }

        [Column("FK_INDICE")]
        [PgmColumn(DisplayText = "Cód. Índice")]
        public string FkIndice { get; set; }
        [ForeignKey(nameof(FkIndice))]
        public virtual DbIndice Indice { get; set; }

        [Column("FK_MOEDA")]
        [PgmColumn(DisplayText = "Cód. Moeda")]
        public string FkMoeda { get; set; }
        [ForeignKey(nameof(FkMoeda))]
        public virtual DbMoeda Moeda { get; set; }

    }
}
