using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUEMPRESATIPO")]
    public class DbEmpresaTipo : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        public int Id { get; set; }

        [Column("DS_NOME")]
        [PgmColumn(DisplayText = "Tipo")]
        public string Nome { get; set; }

    }
}
