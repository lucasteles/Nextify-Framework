using Pragma.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model.Movimentação
{
    [Table("TCLUBOLETA")]
    public class DbBoleta : BaseModel, IModelWithKey<decimal>
    {
        [Key]
        [Column("PK_ID")]
        public decimal Id { get; set; }

        [Column("FK_ESTCOTA")]
        public int? FkEstcota { get; set; }

        [Column("FK_CLUBE")]
        public decimal FkInvestimento { get; set; }

        [Column("DT_MOVTO")]
        public System.DateTime DtMovto { get; set; }

        [Column("FK_COTISTA")]
        public decimal FkCotista { get; set; }

        [Column("VL_MOVTO")]
        public decimal VlMovto { get; set; }

        [Column("DT_LIQUIDACAO")]
        public System.DateTime DtLiquidacao { get; set; }

        [Column("DT_CONVERSAO")]
        public System.DateTime DtConversao { get; set; }

        [Column("TG_MOVTO")]
        public string TgMovto { get; set; }

        [Column("QT_MOVTO")]
        public decimal? QtMovto { get; set; }

        /// <summary>
        /// Ajusta o sinal (positivo/negativo) do QtMovto de acordo com o TgMovto
        /// </summary>
        public virtual decimal? QtMovtoSigned
        {
            get { return Math.Abs(QtMovto.Value) * (TgMovto == "A" ? 1 : -1); }

        }

        [Column("QT_COTIZADA")]
        public decimal? QtCotizada { get; set; }

        [Column("TG_COTIZADA")]
        public decimal? TgCotizada { get; set; }

        [Column("TG_VOUQ")]
        public decimal? TgVouq { get; set; }

        [Column("VL_BRUTO")]
        public decimal? VlBruto { get; set; }

        [Column("VL_LIQUIDO")]
        public decimal? VlLiquido { get; set; }

        [Column("VL_IRRF")]
        public decimal? VlIrrf { get; set; }

        /// <summary>
        /// Ajusta o sinal (positivo/negativo) do ( VlIRRF + VlIOF ) de acordo com o TgMovto
        /// </summary>
        public virtual decimal VlImpostoSigned
        {
            get { return (Math.Abs(VlIrrf.Value) + Math.Abs(VlIof.Value)) * (TgMovto == "A" ? 1 : -1); }
        }

        /// <summary>
        /// Valor bruto total da operação (com IRRF + IOF)
        /// </summary>
        public virtual decimal VlBrutoCorrigidoSigned
        {
            get { return VlLiquidoSigned + VlImpostoSigned; }
        }

        [Column("VL_IOF")]
        public decimal? VlIof { get; set; }

        [Column("TG_RESGTUDO")]
        public decimal TgResgtudo { get; set; }

        [Column("FK_USUARIO")]
        public decimal FkUsuario { get; set; }

        [Column("TG_ORIGEM")]
        public decimal TgOrigem { get; set; }

        [Column("FK_TIPMOVTO")]
        public string FkTipmovto { get; set; }

        [Column("FK_CONTALIQ")]
        public decimal? FkContaliq { get; set; }

        [Column("FK_TIPLIQUIDACAO")]
        public string FkTipliquidacao { get; set; }

        [Column("DH_ENVREM")]
        public System.DateTime? DhEnvrem { get; set; }

        [Column("DH_ENVRET")]
        public System.DateTime? DhEnvret { get; set; }

        [Column("DS_MOVTO")]
        public string DsMovto { get; set; }

        [Column("VL_CPMF")]
        public decimal? VlCpmf { get; set; }

        [Column("TG_INVESTIMENTO")]
        public decimal? TgInvestimento { get; set; }

        [Column("CD_BOLETAGESTOR")]
        public int? CdBoletagestor { get; set; }

        [Column("tg_Automatico")]
        public byte? TgAutomatico { get; set; }

        [Column("TG_REALOCACAO")]
        public byte? TgRealocacao { get; set; }

        [Column("TG_CARTADM")]
        public byte? TgCartadm { get; set; }

        [Column("DS_INVESTIMENTO")]
        public string DsInvestimento { get; set; }

        [Column("TG_CPMF")]
        public byte? TgCpmf { get; set; }

        [Column("VL_PORCPMF")]
        public decimal? VlPorcpmf { get; set; }

        [Column("TG_ESTRANGEIRO")]
        public byte? TgEstrangeiro { get; set; }

        [Column("TG_SWAP")]
        public byte? TgSwap { get; set; }

        [Column("VL_COTSWAP")]
        public decimal? VlCotswap { get; set; }

        [Column("VL_MOVSWAP")]
        public decimal? VlMovswap { get; set; }

        [Column("FK_BOLETAORIGEM")]
        public int? FkBoletaorigem { get; set; }

        [Column("TG_IRRF")]
        public byte? TgIrrf { get; set; }

        [Column("TG_RESGTOTDIG")]
        public byte? TgResgtotdig { get; set; }

        [Column("VL_MOVTODIF")]
        public decimal? VlMovtodif { get; set; }

        [Column("VL_CORRIGIDO")]
        public decimal? VlCorrigido { get; set; }

        /// <summary>
        /// Ajusta o sinal (positivo/negativo) do VlCorrigido (Valor Liquido ajustado eplos MovCotas) de acordo com o TgMovto
        /// </summary>
        public virtual decimal VlLiquidoSigned
        {
            get { return Math.Abs(VlCorrigido ?? 0) * (TgMovto == "A" ? 1 : -1); }
        }

        [Column("FK_MOTIVOMOVTO")]
        public int? FkMotivomovto { get; set; }

        [Column("TG_PROCESSAMENTO")]
        public int? TgProcessamento { get; set; }

        [Column("DT_COTIZACAOCLUBE")]
        public System.DateTime? DtCotizacaoclube { get; set; }

        [Column("TG_ORDEMMOVGERADA")]
        public decimal? TgOrdemmovgerada { get; set; }

        [Column("TG_IMPLANTACAO")]
        public byte? TgImplantacao { get; set; }

        [Column("TG_LIQUIDACAODIG")]
        public byte? TgLiquidacaodig { get; set; }

        [Column("TG_SPEDINGRATE")]
        public byte? TgSpedingrate { get; set; }

        [Column("TG_FORCADTLIQUIDEZ")]
        public decimal? TgForcadtliquidez { get; set; }

        [Column("FK_MOEDA")]
        public string FkMoeda { get; set; }

        [Column("FK_CONTACLI")]
        public decimal? FkContacli { get; set; }

        [Column("VL_COTA")]
        public decimal? VlCota { get; set; }

    }
}
