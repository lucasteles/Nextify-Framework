using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using Pragma.Core;

namespace Pragma.App.Model
{
    [Table("TCLUCADATIVOSEPARACAO")]
    public class DbAtivoSeparacao : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód.")]
        [PgmF4(Show = true)]
        public int Id { get; set; }

        [Column("DS_NOME")]
        [PgmColumn(DisplayText = "Separação")]
        [PgmF4(Show = true)]
        public string Nome { get; set; }

    }
}
