using Pragma.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUMOVCOTA")]
    public class DbMovCota : BaseModel, IModelWithKey<decimal>
    {
        [Key]
        [Column("PK_ID")]
        public decimal Id { get; set; }

        [Column("FK_CLUBE")]
        public decimal FkInvestimento { get; set; }

        [Column("FK_COTISTA")]
        public decimal FkCotista { get; set; }

        [Column("DT_MOVTO")]
        public System.DateTime DtMovto { get; set; }

        [Column("DT_LIQUIDACAO")]
        public System.DateTime? DtLiquidacao { get; set; }

        [Column("TG_MOVTO")]
        public string TgMovto { get; set; }

        [Column("QT_MOVTO")]
        public decimal QtMovto { get; set; }

        /// <summary>
        /// Ajusta o sinal (positivo/negativo) do QtMovto de acordo com o TgMovto
        /// </summary>
        public virtual decimal QtMovtoSigned
        {
            get { return Math.Abs(QtMovto) * (TgMovto == "A" ? 1 : -1); }
        }

        /// <summary>
        /// Corresponde ao Valor Bruto de IR
        /// </summary>
        [Column("VL_MOVTO")]
        public decimal? VlMovto { get; set; }

        /// <summary>
        /// Ajusta o sinal (positivo/negativo) do VlMovto (valor bruto de IR) de acordo com o TgMovto
        /// </summary>
        public virtual decimal VlMovtoSigned
        {
            get { return Math.Abs(VlMovto.Value) * (TgMovto == "A" ? 1 : -1); }
        }

        [Column("VL_LIQUIDO")]
        public decimal? VlLiquido { get; set; }

        [Column("VL_IRRF")]
        public decimal? VlIrrf { get; set; }

        [Column("VL_IOF")]
        public decimal? VlIof { get; set; }

        [Column("FK_HISTORICO")]
        public int? FkHistorico { get; set; }

        [Column("FK_ESTCOTA")]
        public int? FkEstcota { get; set; }

        [Column("FK_BOLETA")]
        public int? FkBoleta { get; set; }

        [Column("TG_ORIGEM")]
        public decimal TgOrigem { get; set; }

        [Column("VL_LUCRO")]
        public decimal? VlLucro { get; set; }

        [Column("VL_PERFORMANCE")]
        public decimal? VlPerformance { get; set; }

        [Column("DH_ENVREM")]
        public System.DateTime? DhEnvrem { get; set; }

        [Column("DH_ENVRET")]
        public System.DateTime? DhEnvret { get; set; }

        [Column("NR_CAUTELA")]
        public int? NrCautela { get; set; }

        [Column("DS_MOVTO")]
        public string DsMovto { get; set; }

        [Column("TG_ESTRANGEIRO")]
        public byte? TgEstrangeiro { get; set; }

        [Column("TG_REALOCACAO")]
        public byte? TgRealocacao { get; set; }

        [Column("TG_CARTADM")]
        public byte? TgCartadm { get; set; }

        [Column("TG_CPMF")]
        public byte? TgCpmf { get; set; }

        [Column("VL_CPMF")]
        public decimal? VlCpmf { get; set; }

        [Column("TG_SWAP")]
        public byte? TgSwap { get; set; }

        [Column("VL_COTSWAP")]
        public decimal? VlCotswap { get; set; }

        [Column("VL_MOVSWAP")]
        public decimal? VlMovswap { get; set; }

        [Column("TG_RESGTOTDIG")]
        public byte? TgResgtotdig { get; set; }

        [Column("VL_MOVTODIF")]
        public decimal? VlMovtodif { get; set; }

        [Column("VL_DIGITADO")]
        public decimal? VlDigitado { get; set; }

        [Column("TG_RESGTUDO")]
        public int? TgResgtudo { get; set; }

        [Column("TG_IMPLANTACAO")]
        public byte? TgImplantacao { get; set; }

        [Column("TG_CONVLIQUIDACAO")]
        public byte? TgConvliquidacao { get; set; }

        [Column("TG_SPEDINGRATE")]
        public byte? TgSpedingrate { get; set; }

        [Column("FK_MOEDA")]
        public string FkMoeda { get; set; }

        [Column("DT_SOLICITACAO")]
        public System.DateTime? DtSolicitacao { get; set; }

    }
}
