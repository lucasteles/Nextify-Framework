using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUMOVIMENTOSTATUSETAPAS")]
    public class DbMovimentacaoStatusEtapas : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        public int Id { get; set; }

        [Column("FK_MOVIMENTOSTATUS")]
        [PgmColumn(DisplayText = "Cód Status")]
        public int FkMovimentoStatus { get; set; }
        [ForeignKey(nameof(FkMovimentoStatus))]
        public virtual DbMovimentacaoStatus MovimentoStatus { get; set; }

        [Column("FK_MOVIMENTOSTATUSPROXIMO")]
        [PgmColumn(DisplayText = "Cód Proxímo Status")]
        public int FkMovimentoStatusProximo { get; set; }
        [ForeignKey(nameof(FkMovimentoStatusProximo))]
        public virtual DbMovimentacaoStatus MovimentoStatusProximo { get; set; }

    }
}