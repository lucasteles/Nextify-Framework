
using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUMODOLIQUIDACAO")]
    public class DbLiquidacaoModo : BaseModel, IModelWithKey<string>
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Modo de Liquidação")]
        [PgmF4(Show = true)]
        public string Id { get; set; }

    }
}