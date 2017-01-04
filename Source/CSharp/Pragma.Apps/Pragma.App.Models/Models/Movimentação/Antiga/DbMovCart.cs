using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUMOVCART")]
    public class DbMovCart : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        public int Id { get; set; }

        [Column("FK_CLUBE")]
        public int FkInvestimento { get; set; }

        [Column("TG_CV")]
        public string TgCv { get; set; }

        [Column("DT_MOVTO")]
        public System.DateTime DtMovto { get; set; }

        [Column("DT_BLOQ")]
        public System.DateTime? DtBloq { get; set; }

        [Column("DT_LIQUIDACAO")]
        public System.DateTime? DtLiquidacao { get; set; }

        [Column("DT_COTA")]
        public System.DateTime? DtCota { get; set; }

        [Column("FK_ATIVO")]
        public string FkAtivo { get; set; }
        [ForeignKey(nameof(FkAtivo))]
        public virtual DbInvestAtivo Ativo { get; set; }

        [Column("FK_TIPOATIVO")]
        public decimal FkTipoativo { get; set; }

        [Column("QT_MOVTO")]
        public decimal? QtMovto { get; set; }

        [Column("VL_PREUNI")]
        public decimal VlPreuni { get; set; }

        [Column("VL_PRETOT")]
        public decimal VlPretot { get; set; }

        [Column("QT_LOTE")]
        public decimal QtLote { get; set; }

        [Column("TG_ORIGEM")]
        public string TgOrigem { get; set; }

        [Column("DS_VENCIMENTO")]
        public string Vencimento { get; set; }

        [Column("DT_VENCIMENTO")]
        public System.DateTime? DtVencimento { get; set; }

        [Column("TG_OPERACAO")]
        public string TgOperacao { get; set; }

        [Column("FK_CORRETORA")]
        public string FkCorretora { get; set; }

        [Column("VL_PORDESCONTO")]
        public decimal? VlPordesconto { get; set; }

        [Column("VL_IRRF")]
        public decimal? VlIrrf { get; set; }

        [Column("VL_IOF")]
        public decimal? VlIof { get; set; }

        [Column("VL_LIQUIDO")]
        public decimal VlLiquido { get; set; }

        [Column("FK_TIPOLIQUIDACAO")]
        public string FkTipoliquidacao { get; set; }

        [Column("CD_INDEXADOR")]
        public string CdIndexador { get; set; }

        [Column("CD_EMISSOR")]
        public string CdEmissor { get; set; }

        [Column("DT_EMISSAO")]
        public System.DateTime? DtEmissao { get; set; }

        [Column("DT_BASEEMISSAO")]
        public System.DateTime? DtBaseemissao { get; set; }

        [Column("VL_TXEMISSAO")]
        public decimal? VlTxemissao { get; set; }

        [Column("VL_PUEMISSAO")]
        public decimal? VlPuemissao { get; set; }

        [Column("TG_MTM")]
        public string TgMtm { get; set; }

        [Column("FK_MODOLIQUIDACAO")]
        public string FkModoliquidacao { get; set; }

        [Column("DH_ENVREM")]
        public System.DateTime? DhEnvrem { get; set; }

        [Column("DH_ENVRET")]
        public System.DateTime? DhEnvret { get; set; }

        [Column("VL_PORTAXA")]
        public decimal? VlPortaxa { get; set; }

        [Column("FK_NOTACORRETAGEM")]
        public int? FkNotacorretagem { get; set; }

        [Column("CD_OPCAO")]
        public string CdOpcao { get; set; }

        [Column("tg_Resgtotal")]
        public decimal? TgResgtotal { get; set; }

        [Column("CD_BANCO")]
        public decimal? CdBanco { get; set; }

        [Column("CD_AGENCIA")]
        public decimal? CdAgencia { get; set; }

        [Column("CD_CCORRENTE")]
        public string CdCcorrente { get; set; }

        [Column("CD_BOLETAGESTOR")]
        public int? CdBoletagestor { get; set; }

        [Column("CD_MOEDA")]
        public string CdMoeda { get; set; }

        [Column("QT_CARTEIRAANT")]
        public decimal? QtCarteiraant { get; set; }

        [Column("VL_PREUNIANT")]
        public decimal? VlPreuniant { get; set; }

        [Column("VL_PRETOTANT")]
        public decimal? VlPretotant { get; set; }

        [Column("VL_RENDIMENTO")]
        public decimal? VlRendimento { get; set; }

        [Column("VL_DIVIDENDO")]
        public decimal? VlDividendo { get; set; }

        [Column("QT_CARTEIRADIG")]
        public decimal? QtCarteiradig { get; set; }

        [Column("VL_PRETOTDIG")]
        public decimal? VlPretotdig { get; set; }

        [Column("tg_Automatico")]
        public byte? TgAutomatico { get; set; }

        [Column("VL_PRINCIPAL")]
        public decimal? VlPrincipal { get; set; }

        [Column("VL_MOVPRINCIPAL")]
        public decimal? VlMovprincipal { get; set; }

        [Column("TG_SWAP")]
        public int? TgSwap { get; set; }

        [Column("tg_Realocacao")]
        public int? TgRealocacao { get; set; }

        [Column("VL_PREUNIMOV")]
        public decimal? VlPreunimov { get; set; }

        [Column("TG_DATAFORCADA")]
        public decimal? TgDataforcada { get; set; }

        [Column("VL_COTACONVERSAO")]
        public decimal? VlCotaconversao { get; set; }

        [Column("TG_COTACONVERSAO")]
        public byte? TgCotaconversao { get; set; }

        [Column("TG_MOVDIG")]
        public decimal? TgMovdig { get; set; }

        [Column("TG_BLOQCOMPR")]
        public int? TgBloqcompr { get; set; }

        [Column("CD_INTERNOGESTOR")]
        public string CdInternoGestor { get; set; }

    }
}
