using Pragma.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUCARTEIRA")]
    public class DbInvestimentoPosicao : BaseModel, IModelWithKey<decimal>
    {
        [Key]
        [Column("PK_ID")]
        public decimal Id { get; set; }

        [Column("FK_CLUBE")]
        [PgmColumn(DisplayText = "Cód Investimento")]
        public decimal FkInvestimento { get; set; }
        [ForeignKey(nameof(FkInvestimento))]
        public virtual DbInvestimento Investimento { get; set; }

        [Column("FK_ATIVO")]
        [PgmColumn(DisplayText = "Cód. Ativo")]
        public string FkAtivo { get; set; }

        [ForeignKey(nameof(FkAtivo))]
        public virtual DbInvestAtivo Ativo { get; set; }

        /// <summary>
        /// Carrega os dados auxiliares de AtivoIsento
        /// </summary>
        [ForeignKey(nameof(Vencimento))]
        public virtual DbAtivoIsento AtivoIsento { get; set; }

        /// <summary>
        /// Campo virtual utilizado para auxiliar em manipulaçõe se Listas de Posições. Não carrega nenhum valor significativo que não se ja para um contexto local.
        /// </summary>
        public bool Desconsiderar = false;

        [Column("DS_VENCIMENTO")]
        [PgmColumn(DisplayText = "Vencimento/Cód")]
        public string Vencimento { get; set; }

        [Column("DT_CARTEIRA")]
        [PgmColumn(DisplayText = "Dt. Posição")]
        public DateTime DtPosicao { get; set; }

        [Column("QT_CARTEIRA")]
        [PgmColumn(DisplayText = "Qt. Carteira")]
        public decimal QtCarteira { get; set; }

        [Column("QT_BLOQUEADA")]
        [PgmColumn(DisplayText = "Qt. Bloqueada")]
        public decimal QtBloqueada { get; set; }

        [Column("QT_PENDENTE")]
        [PgmColumn(DisplayText = "Qt. Pendente")]
        public decimal QtPendente { get; set; }

        [Column("VL_COTACAO")]
        [PgmColumn(DisplayText = "Vl. Cotação")]
        public decimal VlCotacao { get; set; }

        [Column("VL_CUSMED")]
        [PgmColumn(DisplayText = "Vl. Custo Médio")]
        public decimal VlCusMed { get; set; }

        [Column("VL_PRETOT")]
        [PgmColumn(DisplayText = "Vl. PreTot")]
        public decimal VlPreTot { get; set; }

        [Column("VL_EMTRANSITO")]
        [PgmColumn(DisplayText = "Vl. EmTransito")]
        public decimal VlEmTransito { get; set; }

        [Column("VL_BRUTO")]
        [PgmColumn(DisplayText = "Vl. Bruto")]
        public decimal VlBruto { get; set; }

        [Column("VL_IRRF")]
        [PgmColumn(DisplayText = "Vl. Irrf")]
        public decimal VlIrrf { get; set; }

        [Column("VL_PATRIMONIO")]
        [PgmColumn(DisplayText = "Vl. Patrimonio")]
        public decimal VlPatrimonio { get; set; }

        [Column("VL_VENCTO")]
        [PgmColumn(DisplayText = "Vl. VencTo")]
        public decimal VlVencTo { get; set; }

        [Column("VL_PORVARDIA")]
        [PgmColumn(DisplayText = "Vl. PorVarDia")]
        public decimal VlPorVarDia { get; set; }

        [Column("VL_AJUSTE1")]
        [PgmColumn(DisplayText = "Vl. Dividendo")]
        public decimal VlDividendo { get; set; }

        [Column("DT_INICIO")]
        [PgmColumn(DisplayText = "Dt. Inicio")]
        public DateTime DtInicio { get; set; }

        [Column("QT_LOTE")]
        [PgmColumn(DisplayText = "Qt. Lote")]
        public decimal QtLote { get; set; }

        [Column("FK_TIPOATIVO")]
        [PgmColumn(DisplayText = "Cód. Tipo Ativo")]
        public int FkTipoAtivo { get; set; }
        [ForeignKey(nameof(FkTipoAtivo))]
        public virtual DbAtivoTipo TipoAtivo { get; set; }

        [Column("CD_OPCAO")]
        [PgmColumn(DisplayText = "Cód. Opção")]
        public string CdOpcao { get; set; }

        [Column("VL_CUSTOT")]
        [PgmColumn(DisplayText = "Vl. Custo Total")]
        public decimal VlCusTot { get; set; }

        [Column("VL_MOEDA")]
        [PgmColumn(DisplayText = "Vl. Moeda")]
        public decimal VlMoeda { get; set; }

        [Column("VL_PATRIMONIOANT")]
        [PgmColumn(DisplayText = "Vl. Patrimonio Anterior")]
        public decimal VlPatrimonioAnt { get; set; }

        [Column("VL_MOVIMENTOANT")]
        [PgmColumn(DisplayText = "Vl. Movimento")]
        public decimal VlMovimentoAnt { get; set; }

        [Column("TG_ESTRANGEIRO")]
        [PgmColumn(DisplayText = "Estrangeiro")]
        public byte? TgEstrangeiro { get; set; }

        [Column("TG_SEMCOTACAO")]
        [PgmColumn(DisplayText = "Sem Cotação")]
        public byte? TgSemCotacao { get; set; }

        [Column("VL_PORTAXA")]
        [PgmColumn(DisplayText = "Vl. Por. Taxa")]
        public decimal VlPorTaxa { get; set; }

        [Column("FK_MOEDA")]
        [PgmColumn(DisplayText = "Cód. Moeda")]
        public string FkMoeda { get; set; }
        [ForeignKey(nameof(FkMoeda))]
        public virtual DbIndice Moeda { get; set; }

        [Column("TG_SEMQTD")]
        [PgmColumn(DisplayText = "Sem QTD.")]
        public byte? TgSemQtd { get; set; }

        [Column("VL_OFFMOV")]
        [PgmColumn(DisplayText = "Vl. Off. Mov.")]
        public decimal VlOffMov { get; set; }

        [Column("VL_OFFREN")]
        [PgmColumn(DisplayText = "Vl. Off. Ren.")]
        public decimal VlOffRen { get; set; }

        [Column("VL_COTREAL")]
        [PgmColumn(DisplayText = "Vl. Cot. Real")]
        public decimal VlCotReal { get; set; }

        [Column("TG_DESCONSIDERAR")]
        [PgmColumn(DisplayText = "Desconsiderar")]
        public byte? TgDesconsiderar { get; set; }

        [Column("VL_PRINCIPAL")]
        [PgmColumn(DisplayText = "Vl. Principal")]
        public decimal VlPrincipal { get; set; }

        [Column("VL_MOVPRINCIPAL")]
        [PgmColumn(DisplayText = "Vl. Mov. Principal")]
        public decimal VlMovPrincipal { get; set; }

        [Column("VL_COTARENT")]
        [PgmColumn(DisplayText = "Vl. Rentab. Cota")]
        public decimal VlCotaRent { get; set; }

        [Column("CD_INTERNOGESTOR")]
        [PgmColumn(DisplayText = "Cód Interno Gestor")]
        public string CdInternoGestor { get; set; }

        [Column("VL_IOF")]
        [PgmColumn(DisplayText = "Vl. IOF")]
        public decimal VlIof { get; set; }

        [Column("VL_PATRBRUTO")]
        [PgmColumn(DisplayText = "Vl. Patr. Bruto")]
        public decimal VlPatrBruto { get; set; }

        [Column("VL_MOVTOAJUSTEBRUTO")]
        [PgmColumn(DisplayText = "Vl. Mov. Ajuste Bruto")]
        public decimal VlMovtoAjusteBruto { get; set; }

        [Column("NR_CNPJINTER")]
        [PgmColumn(DisplayText = "CNPJ Inter.")]
        public decimal NrCNPJInter { get; set; }

        [Column("VL_TXALUG")]
        [PgmColumn(DisplayText = "Vl. taxa de Aluguel")]
        public decimal VlTxAlug { get; set; }

        [Column("TG_CLASSEOPERACAO")]
        [PgmColumn(DisplayText = "Classe Opção")]
        public char TgClasseOperacao { get; set; }

        [Column("TG_MANTERIRRF")]
        [PgmColumn(DisplayText = "Manter IRRF")]
        public decimal TgManterIrrf { get; set; }

        [Column("TG_MANTERMOVTOANT")]
        [PgmColumn(DisplayText = "Manter Mov.Ant.")]
        public decimal TgManterMovtoAnt { get; set; }

        [Column("VL_MOVTOBRUTO")]
        [PgmColumn(DisplayText = "Vl. Mov. Bruto")]
        public decimal TgMovtoBruto { get; set; }

        [Column("VL_PATRIMONIOBANCO")]
        [PgmColumn(DisplayText = "Vl. Patrimonio do Banco")]
        public decimal VlPatrimonioBanco { get; set; }

        [Column("VL_MOVBANCO")]
        [PgmColumn(DisplayText = "Vl. Mov. do Banco")]
        public decimal VlMovBanco { get; set; }

        [Column("DT_VENCIMENTO")]
        [PgmColumn(DisplayText = "Dt. Vencimento")]
        public DateTime? DtVencimento { get; set; }

        [Column("VL_TXGES")]
        [PgmColumn(DisplayText = "Vl. Tx. Gestão")]
        public decimal? VlTxGes { get; set; }

        [Column("VL_TXADM")]
        [PgmColumn(DisplayText = "Vl. Tx. Administração")]
        public decimal? VlTxAdm { get; set; }

        #region XML 5.0 De/Para

        //[Key]
        //[Column("PK_ID")]
        //public decimal Id { get; set; }

        //[Column("FK_CLUBE")]
        //public decimal FkClube { get; set; }

        //[Column("FK_ATIVO")]
        //public string FkAtivo { get; set; }

        //[Column("DS_VENCIMENTO")]
        //public string DsVencimento { get; set; }

        //[Column("DT_CARTEIRA")]
        //public DateTime DtCarteira { get; set; }

        //[Column("QT_CARTEIRA")]
        //public decimal? QtCarteira { get; set; }

        //[Column("QT_BLOQUEADA")]
        //public decimal? QtBloqueada { get; set; }

        //[Column("QT_PENDENTE")]
        //public decimal? QtPendente { get; set; }

        //[Column("VL_COTACAO")]
        //public decimal VlCotacao { get; set; }

        //[Column("VL_CUSMED")]
        //public decimal? VlCusMed { get; set; }

        //[Column("VL_PRETOT")]
        //public decimal VlPretot { get; set; }

        //[Column("VL_EMTRANSITO")]
        //public decimal VlEmTransito { get; set; }

        //[Column("VL_BRUTO")]
        //public decimal VlBruto { get; set; }

        //[Column("VL_IRRF")]
        //public decimal VlIrrf { get; set; }

        //[Column("VL_PATRIMONIO")]
        //public decimal VlPatrimonio { get; set; }

        //[Column("VL_VENCTO")]
        //public decimal VlVencto { get; set; }

        //[Column("VL_PORVARDIA")]
        //public decimal? VlPorvardia { get; set; }

        //[Column("VL_AJUSTE1")]
        //public decimal VlAjuste1 { get; set; }

        //[Column("DT_INICIO")]
        //public DateTime DtInicio { get; set; }

        //[Column("QT_LOTE")]
        //public decimal QtLote { get; set; }

        //[Column("FK_TIPOATIVO")]
        //public int? FkTipoAtivo { get; set; }

        //[Column("CD_OPCAO")]
        //public string CdOpcao { get; set; }

        //[Column("VL_CUSTOT")]
        //public decimal? VlCustoT { get; set; }

        //[Column("VL_MOEDA")]
        //public decimal? VlMoeda { get; set; }

        //[Column("VL_PATRIMONIOANT")]
        //public decimal? VlPatrimonioAnt { get; set; }

        //[Column("VL_MOVIMENTOANT")]
        //public decimal? VlMovimentoAnt { get; set; }

        //[Column("fk_Parent")]
        //public int? FkParent { get; set; }

        //[Column("TG_ESTRANGEIRO")]
        //public byte? TgEstrangeiro { get; set; }

        //[Column("TG_SEMCOTACAO")]
        //public byte? TgSemCotacao { get; set; }

        //[Column("VL_PORTAXA")]
        //public decimal? VlPorTaxa { get; set; }

        //[Column("FK_MOEDA")]
        //public string FkMoeda { get; set; }

        //[Column("TG_SEMQTD")]
        //public byte? TgSemQtd { get; set; }

        //[Column("VL_OFFMOV")]
        //public decimal? VlOffMov { get; set; }

        //[Column("VL_OFFREN")]
        //public decimal? VlOffRen { get; set; }

        //[Column("VL_COTREAL")]
        //public decimal? VlCotReal { get; set; }

        //[Column("TG_DESCONSIDERAR")]
        //public byte? TgDesconsiderar { get; set; }

        //[Column("VL_PRINCIPAL")]
        //public decimal? VlPrincipal { get; set; }

        //[Column("VL_MOVPRINCIPAL")]
        //public decimal? VlMovPrincipal { get; set; }

        //[Column("VL_COTARENT")]
        //public decimal? VlCotaRent { get; set; }

        //[Column("CD_INTERNOGESTOR")]
        //public string CdInternoGestor { get; set; }

        //[Column("VL_IOF")]
        //public decimal? VlIof { get; set; }

        //[Column("VL_PATRBRUTO")]
        //public decimal? VlPatrBruto { get; set; }

        //[Column("VL_MOVTOAJUSTEBRUTO")]
        //public decimal? VlMovtoAjusteBruto { get; set; }

        //[Column("NR_CNPJINTER")]
        //public decimal? NrCnpjInter { get; set; }

        //[Column("VL_TXALUG")]
        //public decimal? VlTxAlug { get; set; }

        //[Column("TG_CLASSEOPERACAO")]
        //public string TgClasseOperacao { get; set; }

        //[Column("TG_MANTERIRRF")]
        //public decimal? TgManterIrrf { get; set; }

        //[Column("TG_MANTERMOVTOANT")]
        //public decimal? TgManterMovtoAnt { get; set; }

        //[Column("VL_MOVTOBRUTO")]
        //public decimal? VlMovtoBruto { get; set; }

        //[Column("VL_PATRIMONIOBANCO")]
        //public decimal? VlPatrimoniobanco { get; set; }

        //[Column("VL_MOVBANCO")]
        //public decimal? VlMovbanco { get; set; }

        //[Column("DT_VENCIMENTO")]
        //public DateTime? DtVencimento { get; set; }

        //[Column("VL_TXGES")]
        //public decimal? VlTxGes { get; set; }

        //[Column("VL_TXADM")]
        //public decimal? VlTxAdm { get; set; }

        #endregion

        /* TODO : Map this
            oModelBuilder.Entity<DbInvestimentoPosicao>().Property(i => i.QtCarteira).HasPrecision(20, 8);
            oModelBuilder.Entity<DbInvestimentoPosicao>().Property(i => i.VlCotacao).HasPrecision(18, 8);
            
        */
    }
}
