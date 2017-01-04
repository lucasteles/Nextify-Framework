using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUALAVANCAGEMITEM")]
    public class DbAlavancagemItem : BaseModel, IModelWithKey
    {
        [ForeignKey(nameof(FkAlavancagem))]
        public virtual DbAlavancagem Alavancagem { get; set; }
        [ForeignKey(nameof(FkAtivoOut))]
        public virtual DbInvestAtivo AtivoOut { get; set; }

        [Column("FK_ALAVANCAGEM")]
        [PgmColumn(DisplayText = "Cód Alavancagem")]
        public int FkAlavancagem { get; set; }

        [Column("FK_ATIVOOUT")]
        [PgmColumn(DisplayText = "Cód. Ativo")]
        public string FkAtivoOut { get; set; }

        [Column("FK_CLUBE")]
        [PgmColumn(DisplayText = "Cód Investimento")]
        public decimal FkInvestimento { get; set; }

        [Column("FK_SETORIN")]
        public int FkSetorIn { get; set; }

        [Column("FK_SETOROUT")]
        public int FkSetorOut { get; set; }
        [ForeignKey(nameof(FkInvestimento))]
        public virtual DbInvestimento Investimento { get; set; }
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        public int Id { get; set; }
        [ForeignKey(nameof(FkSetorIn))]
        public virtual DbAtivoClasse SetorIn { get; set; }
        [ForeignKey(nameof(FkSetorOut))]
        public virtual DbAtivoClasse SetorOut { get; set; }

        [Column("TG_DESCONSIDERARIN")]
        public decimal TgDesconsiderarIn { get; set; }

        [Column("TG_DESCONSIDERAROUT")]
        public decimal TgDesconsiderarOut { get; set; }

        [Column("TG_FORCARPLTOT")]
        [PgmColumn(DisplayText = "Força Pl Total")]
        public decimal TgForcePlTot { get; set; }

        [Column("VL_PORAJUSTE")]
        [PgmColumn(DisplayText = "Vl. Por. Ajuste")]
        public decimal VlPorAjuste { get; set; }

    }
}
