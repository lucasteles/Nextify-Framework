
using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUCONTA_NEW")]
    public class DbConta : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Forma de Liquidação")]
        [PgmF4(Show = true)]
        public int Id { get; set; }

    }
}
