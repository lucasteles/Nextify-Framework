using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TSISUSUEXTERNOORIGEM")]
    // // // [PgmDataBaseAttribute(Connection = PgmGlobal.SysConnectionName)]
    public class DbOrigemExterna : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        public int Id { get; set; }

        [Column("DS_NOME")]
        [PgmColumn(DisplayText = "Nome")]
        public string Nome { get; set; }

    }

}
