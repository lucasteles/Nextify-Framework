using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUAPTEXTO")]
    public class DbPptRelatorioTexto : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        public int Id { get; set; }

        [Column("DS_TEXTO")]
        [PgmColumn(DisplayText = "Texto")]
        public string Texto { get; set; }

        [Column("FK_PAGINA")]
        [PgmColumn(DisplayText = "Fk.Pagina")]
        public string FkPagina { get; set; }

        [Column("CD_PERIODO")]
        [PgmColumn(DisplayText = "Periodo")]
        public string Periodo { get; set; }
    }
}
