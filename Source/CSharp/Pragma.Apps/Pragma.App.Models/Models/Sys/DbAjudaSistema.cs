using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TSISAJUDASISTEMA")]
    // // [PgmDataBaseAttribute(Connection = PgmGlobal.SysConnectionName)]
    public class DbAjudaSistema : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        public int Id { get; set; }

        [Column("DS_NAME")]
        [PgmColumn(DisplayText = "Nome")]
        public string Name { get; set; }

        [Column("DS_CAMPO")]
        [PgmColumn(DisplayText = "Campo")]
        public string Campo { get; set; }

        [Column("DS_FORM")]
        [PgmColumn(DisplayText = "Form")]
        public string Form { get; set; }

        [Column("DS_PARENT")]
        [PgmColumn(DisplayText = "Parent")]
        public string Parent { get; set; }

        [Column("NR_ORDEM")]
        [PgmColumn(DisplayText = "Ordem")]
        public int Ordem { get; set; }

        [Column("DS_AJUDA")]
        [PgmColumn(DisplayText = "Ajuda")]
        public string Ajuda { get; set; }

        [Column("TG_SISTEMA")]
        [PgmColumn(DisplayText = "Sistema")]
        public string Sistema { get; set; }

    }
}
