
using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUTIPOLIQATIVO")]
    public class DbLiquidacaoTipo : BaseModel, IModelWithKey<string>
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Tipo de Liquidação")]
        [PgmF4(Show = true)]
        public string Id { get; set; }

    }
}