using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUINSTITUICAO")]
    public class DbInstituicao : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        public int Id { get; set; }

        [Column("DS_INSTITUICAO")]
        public string Nome { get; set; }

        [Column("TG_ADMINISTRADOR")]
        public int? TgAdministrador { get; set; }

    }
}
