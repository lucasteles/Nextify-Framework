
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using Pragma.Core;

namespace Pragma.App.Model
{
    [Table("TCLUPPTRELATORIOPAGINA")]
    public class DbPptRelatorioPagina : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        public int Id { get; set; }

        [Column("FK_PPTRELATORIO")]
        [PgmColumn(DisplayText = "Cód Relatório")]
        public int FkPptRelatorio { get; set; }
        [ForeignKey(nameof(FkPptRelatorio))]
        public virtual DbPptRelatorio PptRelatorio { get; set; }

        [Column("FK_PPTPAGINA")]
        [PgmColumn(DisplayText = "Cód Pagina")]
        public int FkPptPagina { get; set; }
        [ForeignKey(nameof(FkPptPagina))]
        public virtual DbPptPagina PptPagina { get; set; }

        [Column("NR_ORDEM")]
        [PgmColumn(DisplayText = "Ordem")]
        public int NrOrdem { get; set; }

    }
}
