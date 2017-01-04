using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUMOEDA")]
    public class DbMoeda : BaseModel, IModelWithKey<string>
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        [PgmF4(Show = true)]
        public string Id { get; set; } = "";

        [Column("DS_NOME")]
        [PgmColumn(DisplayText = "Moeda")]
        [PgmF4(Show = true)]
        public string Nome { get; set; }

    }
}
