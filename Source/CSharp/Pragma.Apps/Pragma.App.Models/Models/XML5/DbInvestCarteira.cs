
using Pragma.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUCARTEIRA")]
    // // [PgmDataBaseAttribute(Connection = "HomologIntraConnection")]
    public class DbInvestCarteira : BaseModel, IModelWithKey<decimal>
    {
        [Key]
        [Column("PK_ID")]
        public decimal Id { get; set; }

        [Column("FK_CLUBE")]
        public decimal FkClube { get; set; }

        [Column("FK_ATIVO")]
        public string FkAtivo { get; set; }

        [Column("DS_VENCIMENTO")]
        public string DsVencimento { get; set; }

        [Column("DT_CARTEIRA")]
        public DateTime DtCarteira { get; set; }

        [Column("QT_CARTEIRA")]
        public decimal? QtCarteira { get; set; }

        [Column("QT_BLOQUEADA")]
        public decimal? QtBloqueada { get; set; }

        [Column("QT_PENDENTE")]
        public decimal? QtPendente { get; set; }

        [Column("VL_COTACAO")]
        public decimal VlCotacao { get; set; }

        [Column("VL_CUSMED")]
        public decimal? VlCusMed { get; set; }

        [Column("VL_PRETOT")]
        public decimal VlPretot { get; set; }

        [Column("VL_EMTRANSITO")]
        public decimal VlEmTransito { get; set; }

        [Column("VL_BRUTO")]
        public decimal VlBruto { get; set; }

        [Column("VL_IRRF")]
        public decimal VlIrrf { get; set; }

        [Column("VL_PATRIMONIO")]
        public decimal VlPatrimonio { get; set; }

        [Column("VL_VENCTO")]
        public decimal VlVencto { get; set; }

        [Column("VL_PORVARDIA")]
        public decimal? VlPorvardia { get; set; }

        [Column("VL_AJUSTE1")]
        public decimal VlAjuste1 { get; set; }

        [Column("DT_INICIO")]
        public DateTime DtInicio { get; set; }

        [Column("QT_LOTE")]
        public decimal QtLote { get; set; }

        [Column("FK_TIPOATIVO")]
        public int? FkTipoAtivo { get; set; }

        [Column("CD_OPCAO")]
        public string CdOpcao { get; set; }

        [Column("VL_CUSTOT")]
        public decimal? VlCustoT { get; set; }

        [Column("VL_MOEDA")]
        public decimal? VlMoeda { get; set; }

        [Column("VL_PATRIMONIOANT")]
        public decimal? VlPatrimonioAnt { get; set; }

        [Column("VL_MOVIMENTOANT")]
        public decimal? VlMovimentoAnt { get; set; }

        [Column("fk_Parent")]
        public int? FkParent { get; set; }

        [Column("TG_ESTRANGEIRO")]
        public byte? TgEstrangeiro { get; set; }

        [Column("TG_SEMCOTACAO")]
        public byte? TgSemCotacao { get; set; }

        [Column("VL_PORTAXA")]
        public decimal? VlPorTaxa { get; set; }

        [Column("FK_MOEDA")]
        public string FkMoeda { get; set; }

        [Column("TG_SEMQTD")]
        public byte? TgSemQtd { get; set; }

        [Column("VL_OFFMOV")]
        public decimal? VlOffMov { get; set; }

        [Column("VL_OFFREN")]
        public decimal? VlOffRen { get; set; }

        [Column("VL_COTREAL")]
        public decimal? VlCotReal { get; set; }

        [Column("TG_DESCONSIDERAR")]
        public byte? TgDesconsiderar { get; set; }

        [Column("VL_PRINCIPAL")]
        public decimal? VlPrincipal { get; set; }

        [Column("VL_MOVPRINCIPAL")]
        public decimal? VlMovPrincipal { get; set; }

        [Column("VL_COTARENT")]
        public decimal? VlCotaRent { get; set; }

        [Column("CD_INTERNOGESTOR")]
        public string CdInternoGestor { get; set; }

        [Column("VL_IOF")]
        public decimal? VlIof { get; set; }

        [Column("VL_PATRBRUTO")]
        public decimal? VlPatrBruto { get; set; }

        [Column("VL_MOVTOAJUSTEBRUTO")]
        public decimal? VlMovtoAjusteBruto { get; set; }

        [Column("NR_CNPJINTER")]
        public decimal? NrCnpjInter { get; set; }

        [Column("VL_TXALUG")]
        public decimal? VlTxAlug { get; set; }

        [Column("TG_CLASSEOPERACAO")]
        public string TgClasseOperacao { get; set; }

        [Column("TG_MANTERIRRF")]
        public decimal? TgManterIrrf { get; set; }

        [Column("TG_MANTERMOVTOANT")]
        public decimal? TgManterMovtoAnt { get; set; }

        [Column("VL_MOVTOBRUTO")]
        public decimal? VlMovtoBruto { get; set; }

        [Column("VL_PATRIMONIOBANCO")]
        public decimal? VlPatrimoniobanco { get; set; }

        [Column("VL_MOVBANCO")]
        public decimal? VlMovbanco { get; set; }

        [Column("DT_VENCIMENTO")]
        public DateTime? DtVencimento { get; set; }

        [Column("VL_TXGES")]
        public decimal? VlTxGes { get; set; }

        [Column("VL_TXADM")]
        public decimal? VlTxAdm { get; set; }

    }
}
