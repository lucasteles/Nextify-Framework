using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using Pragma.Core;

namespace Pragma.App.Model
{
    [Table("TCLUCADATIVOREGIAO")]
    public class DbAtivoRegiao : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód.")]
        [PgmF4(Show = true)]
        public int Id { get; set; }

        [Column("DS_NOME")]
        [PgmColumn(DisplayText = "Região")]
        [PgmF4(Show = true)]
        public string Nome { get; set; }

    }
}
