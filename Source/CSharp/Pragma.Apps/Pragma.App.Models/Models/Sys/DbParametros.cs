using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TSISPARAMETROS")]
    // // [PgmDataBaseAttribute(Connection = PgmGlobal.SysConnectionName)]
    public class DbParametros : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        public int Id { get; set; }

        [Column("DS_PARAMETRO")]
        [PgmColumn(DisplayText = "Parametro")]
        public string Parametro { get; set; }

        [Column("DS_DESCRICAO")]
        [PgmColumn(DisplayText = "Descrição")]
        public string Descricao { get; set; }

        [Column("DS_CONTEUDO")]
        [PgmColumn(DisplayText = "Conteudo")]
        public string Conteudo { get; set; }

    }
}
