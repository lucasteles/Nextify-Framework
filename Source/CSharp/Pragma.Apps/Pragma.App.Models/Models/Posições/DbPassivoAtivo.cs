using Pragma.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("VCLUPASSIVOATIVO")]
    public class DbPassivoAtivo : BaseModel
    {
        [Key, Column("FK_CLUBE", Order = 0)]
        public decimal FkInvestimentoInvestidor { get; set; }
        [ForeignKey(nameof(FkInvestimentoInvestidor))]
        public virtual DbInvestimento InvestimentoInvestidor { get; set; }

        [Key, Column("FK_CLUBEPAI", Order = 1)]
        public decimal FkInvestimentoInvestido { get; set; }
        [ForeignKey(nameof(FkInvestimentoInvestido))]
        public virtual DbInvestimento InvestimentoInvestido { get; set; }

        [Key, Column("DT_ATUAL", Order = 3)]
        public DateTime DtPosicao { get; set; }

        [Key, Column("FK_COTISTA", Order = 4)]
        public decimal FkCotista { get; set; }

        [Column("FK_ATIVO")]
        [PgmColumn(DisplayText = "Cód. Ativo")]
        public string FkAtivo { get; set; }
        [ForeignKey(nameof(FkAtivo))]
        public virtual DbInvestAtivo Ativo { get; set; }

        [Column("QT_ATUAL")]
        public decimal QtCotas { get; set; }

        [Column("VL_BRUTO")]
        [PgmColumn(DisplayText = "Vl. PreTot")]
        public decimal VlBrutoIR { get; set; }

        [Column("VL_LIQUIDO")]
        [PgmColumn(DisplayText = "Vl. PreTot")]
        public decimal VlLiquidoIR { get; set; }

        [Column("VL_IRRF")]
        [PgmColumn(DisplayText = "Vl. PreTot")]
        public decimal VlIR { get; set; }

        [Column("DT_APLICACAO")]
        public DateTime DtAplicacao { get; set; }

    }
}
