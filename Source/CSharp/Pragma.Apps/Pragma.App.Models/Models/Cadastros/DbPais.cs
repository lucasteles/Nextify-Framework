using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUPAISES")]
    public class DbPais : BaseModel, IModelWithKey<string>
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        [PgmF4(Show = true)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }

        [Column("DS_NOME")]
        [PgmColumn(DisplayText = "País")]
        [PgmF4(Show = true)]
        public string Nome { get; set; }

        [Column("CD_CONFAZ")]
        [PgmColumn(DisplayText = "CONFAZ")]
        public string ConFaz { get; set; }

        [Column("CD_BACEN")]
        [PgmColumn(DisplayText = "BACEN")]
        public string Bacen { get; set; }

        [Column("DS_NACIONALIDADE")]
        [PgmColumn(DisplayText = "Nacionalidade")]
        [PgmF4(Show = true)]
        public string Nacionalidade { get; set; }

    }
}
