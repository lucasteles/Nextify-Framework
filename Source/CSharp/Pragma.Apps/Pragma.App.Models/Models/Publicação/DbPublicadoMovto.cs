using Pragma.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUCARTCONSMOVTO")]
    public class DbPublicadoMovto : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        public int Id { get; set; }

        [Column("FK_CARTCONS")]
        public int FkCartcons { get; set; }
        [ForeignKey(nameof(FkCartcons))]
        public virtual DbPublicadoIndice CartConsIndice { get; set; }

        [Column("FK_CLUBE")]
        public int FkInvestimento { get; set; }
        //[ForeignKey("FkInvestimento")]
        //public virtual Investimento Investimento { get; set; }

        [Column("TG_LOCAL")]
        public byte TgLocal { get; set; }

        [Column("DS_LOCAL")]
        public string DsLocal { get; set; }

        [Column("TG_SWAP")]
        public byte TgSwap { get; set; }

        [Column("DT_CONVERSAO")]
        public DateTime DtConversao { get; set; }

        [Column("DT_MOVTO")]
        public DateTime DtMovTo { get; set; }

        [Column("TG_MOVTO")]
        public string TgMovTo { get; set; }

        [Column("DS_MOVTO")]
        public string DsMovTo { get; set; }

        [Column("VL_BRUTO")]
        public decimal VlBruto { get; set; }

        [Column("VL_IRRF")]
        public decimal VlIrrf { get; set; }

        [Column("DS_INVESTIMENTO")]
        public string DsInvestimento { get; set; }

        [Column("TG_REALOCACAO")]
        public byte TgRealocacao { get; set; }

        [Column("VL_LIQUIDO")]
        public decimal VlLiquido { get; set; }

        [Column("VL_IMPOSTOS")]
        public decimal VlImposto { get; set; }

        [Column("DS_HISTORICO")]
        public string DsHistorico { get; set; }

        [Column("VL_CPMF")]
        public decimal VlCpmf { get; set; }

        [Column("TG_CPMF")]
        public byte tgCpmf { get; set; }

        [Column("TG_AUTOMATICO")]
        public byte TgAutomatico { get; set; }

        [Column("TG_SPEDINGRATE")]
        public byte TgSpedingrate { get; set; }

        [Column("DS_ORIGEM")]
        public string DsOrigem { get; set; }

        [Column("VL_IOF")]
        public decimal VlIof { get; set; }

        [Column("VL_MOVSWAP")]
        public decimal VlMovSwap { get; set; }

    }
}
