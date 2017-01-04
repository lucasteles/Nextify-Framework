using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUCONJUNTO")]
    public class DbAtivoConjunto : BaseModel, IModelWithKey<string>
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód.")]
        [PgmF4(Show = true)]
        public string Id { get; set; }

        [Column("DS_CONJUNTO")]
        [PgmColumn(DisplayText = "Conjunto")]
        [PgmF4(Show = true)]
        public string Nome { get; set; }

    }
}
