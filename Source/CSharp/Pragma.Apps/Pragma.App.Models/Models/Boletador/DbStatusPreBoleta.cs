using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUPREBOLETASTATUS")]
    public class DbStatusPreBoleta : BaseModel, IModelWithKey
    {
        [Key, Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        public int Id { get; set; }

        [Column("DS_STATUS")]
        [PgmColumn(DisplayText = "Status")]
        public string Nome { get; set; }

    }
}
