
using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    // // [PgmDataBase(Connection = "HomologIntraConnection")]
    [Table("TCLUPAIS")]
    public class DbPaisNovo : BaseModel, IModelWithKey<string>
    {
        [Key]
        [Column("PK_ID")]
        public string Id { get; set; }

        [Column("CD_ALPHA3")]
        public string CodigoAlpha3 { get; set; }

        [Column("DS_NOME")]
        public string Nome { get; set; }

    }
}
