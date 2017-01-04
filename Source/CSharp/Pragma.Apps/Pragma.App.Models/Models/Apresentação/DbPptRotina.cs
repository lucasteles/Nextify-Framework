
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using Pragma.Core;

namespace Pragma.App.Model
{
    [Table("TCLUPPTROTINA")]
    public class DbPptRotina : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        public int Id { get; set; }

        [Column("DS_CLASSNAME")]
        [PgmColumn(DisplayText = "Nome da Classe da apresentação")]
        public string ClassName { get; set; }

    }
}
