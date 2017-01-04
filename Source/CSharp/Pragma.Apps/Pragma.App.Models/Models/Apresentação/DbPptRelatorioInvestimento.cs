
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using Pragma.Core;

namespace Pragma.App.Model
{
    [Table("TCLUPPTRELATORIOCLUBE")]
    public class DbPptRelatorioInvestimento : BaseModel, IModelWithKey
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

        [Column("FK_CLUBE")]
        [PgmColumn(DisplayText = "Cód Investimento")]
        public decimal FkInvestimento { get; set; }
        [ForeignKey(nameof(FkInvestimento))]
        public virtual DbInvestimento Investimento { get; set; }

        [Column("TG_PADRAO")]
        [PgmColumn(DisplayText = "Padrão")]
        public byte TgPadrao { get; set; }

    }
}
