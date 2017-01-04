using Pragma.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUATIVO")]
    public class DbInvestAtivo : BaseModel, IModelWithKey<string>
    {
        [Key, StringLength(12), Column("PK_ID", TypeName = "varchar")]
        [PgmColumn(DisplayText = "Cód")]
        [PgmF4(Show = true)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }

        [Column("DS_ATIVO")]
        [PgmColumn(DisplayText = "Ativo")]
        [PgmF4(Show = true)]
        public string Nome { get; set; }

        [Column("TG_ESTRANGEIRO")]
        [PgmColumn(DisplayText = "Estrangeiro")]
        public byte TgEstrangeiro { get; set; }

        [Column("FK_TIPOATIVO")]
        [PgmColumn(DisplayText = "Cód Tipo Ativo")]
        public int FkTipoAtivo { get; set; }
        [ForeignKey(nameof(FkTipoAtivo))]
        public virtual DbAtivoTipo TipoAtivo { get; set; }

        [Column("FK_SETOR")]
        [PgmColumn(DisplayText = "Cód Classe")]
        public int FkSetor { get; set; }
        [ForeignKey(nameof(FkSetor))]
        public virtual DbAtivoClasse Setor { get; set; }

        [Column("FK_CLASSE")]
        public int FkClasse { get; set; }
        [ForeignKey(nameof(FkClasse))]
        public virtual DbAtivoSubClasse Classe { get; set; }

        [StringLength(8), Column("FK_MOEDAESTRANGEIRA")]
        [PgmColumn(DisplayText = "Cód. Moeda Estrang.")]
        public string FkMoedaEstrang { get; set; }
        [ForeignKey(nameof(FkMoedaEstrang))]
        public virtual DbIndice MoedaEstrang { get; set; }

        [StringLength(8), Column("FK_MOEDAATI")]
        [PgmColumn(DisplayText = "Cód. Moeda Ativo")]
        [PgmF4(Show = true)]
        public string FkMoeda { get; set; }
        [ForeignKey(nameof(FkMoeda))]
        public virtual DbIndice Moeda { get; set; }

        [StringLength(8), Column("FK_MOEDALANC")]
        [PgmColumn(DisplayText = "Cód. Moeda Lanc.")]
        public string FkMoedaLanc { get; set; }
        [ForeignKey(nameof(FkMoedaLanc))]
        public virtual DbIndice MoedaLanc { get; set; }

        [StringLength(8), Column("FK_MOEDAORI")]
        [PgmColumn(DisplayText = "Cód. Moeda Original")]
        public string FkMoedaOri { get; set; }
        [ForeignKey(nameof(FkMoedaOri))]
        public virtual DbIndice MoedaOri { get; set; }

        [Column("CD_EXTERNO")]
        public string CdExterno { get; set; }

        [ForeignKey(nameof(CdExterno))]
        public virtual DbFacAnbid FacAnbid { get; set; }

        //Indica se o ativo utiliza cota especial de integralização 9aplicação) em seus aportes
        [Column("TG_COTAESPECIAL")]
        public decimal? TgCotaEspecial { get; set; }

        [Column("CD_ISIN")]
        public string CdIsin { get; set; }

        [Column("TG_ATIVOBASE")]
        public decimal? TgAtivoBase { get; set; }

        [Column("FK_ATIVOBASE")]
        public string FkAtivoBase { get; set; }

        /// <summary>
        /// Cadastro do Ativo Base relacionado
        /// </summary>
        [ForeignKey(nameof(FkAtivoBase))]
        public virtual DbInvestAtivo AtivoBase { get; set; }

        /// <summary>
        /// Indice Base para a geração de cotações, no caso da flag TgGerarCotacao = 1
        /// </summary>
        [Column("FK_INDICECOTACAO")]
        public string FkIndice { get; set; }

        /// <summary>
        /// Indice Base para a geração de cotações, no caso da flag TgGerarCotacao = 1
        /// </summary>
        [ForeignKey(nameof(FkIndice))]
        public virtual DbIndice Indice { get; set; }

        /// <summary>
        /// Flah que indica se o ativo deve ter geração de cotação/PU diário
        /// </summary>
        [Column("TG_GERARCOTACAO")]
        public decimal? TgGerarCotacao { get; set; }

        /// <summary>
        /// Percentual aplicação sobr a variação diáriad do FkIndice. Por exemplo, um valor de 100 indica 100%.
        /// </summary>
        [Column("VL_PORINDICECOTACAO")]
        public decimal VlPorIndiceCotacao { get; set; }

        /// <summary>
        /// Indica se o atvio deve ser considerado como um recurso de CAIXA. Esta flag é utilziada para conciliações de Fluxo de Caixa, para conferir se o fundo possui recursos em D+0 para pagar as despesas do fundo.
        /// </summary>
        [Column("TG_CAIXA")]
        public decimal? TgCaixa { get; set; }

        /// <summary>
        /// Relaciona com o Investimento que tenha este ativo como seu representante. Ex.: Investimento FIC LIBER (311) possui o Ativo relacionado 1TP814MM.
        /// </summary>
        public virtual ICollection<DbInvestimento> InvestimentoOriginal { get; set; }

        #region XML 5.0 De/Para

        //[Key]
        //[Column("PK_ID")]
        //public string Id { get; set; }

        //[Column("DS_ATIVO")]
        //public string DsAtivo { get; set; }

        //[Column("FK_TIPOATIVO")]
        //public int FkTipoAtivo { get; set; }

        //[Column("TG_ORIGEM")]
        //public int TgOrigem { get; set; }

        //[Column("QT_LOTEPADRAO")]
        //public int? QtLotePadrao { get; set; }

        //[Column("TG_DESCONSIDERAR")]
        //public byte? TgDesconsiderar { get; set; }

        //[Column("TG_ESTRANGEIRO")]
        //public byte? TgEstrangeiro { get; set; }

        //[Column("FK_MOEDAESTRANGEIRA")]
        //public string FkMoedaEstrangeira { get; set; }

        //[Column("TG_OUTRAMOEDA")]
        //public byte? TgOutramoeda { get; set; }

        //[Column("FK_MOEDAATI")]
        //public string FkMoedaAti { get; set; }

        //[Column("TG_RENTABCOTA")]
        //public byte? TgRentabCota { get; set; }

        //[Column("TG_DIASCONV")]
        //public string TgDiasConv { get; set; }

        //[Column("NR_LIQRESGATE")]
        //public int? NrLiqResgate { get; set; }

        //[Column("NR_RESGCONV")]
        //public int? NrResgConv { get; set; }

        //[Column("DS_APELIDO")]
        //public string DsApelido { get; set; }

        //[Column("fk_Instituicao")]
        //public int? FkInstituicao { get; set; }

        //[Column("FK_CADUNICO")]
        //public int? FkCadUnico { get; set; }

        //[Column("FK_REGIAO")]
        //public int? FkRegiao { get; set; }

        //[Column("FK_MOEDAORI")]
        //public string FkMoedaOri { get; set; }

        //[Column("FK_EMISSOR")]
        //public int? FkEmissor { get; set; }

        //[Column("NR_DIASLIQUIDACAO")]
        //public int? NrDiasLiquidacao { get; set; }

        //[Column("DT_VENCIMENTO")]
        //public DateTime? DtVencimento { get; set; }

        //[Column("TG_FORCELIQUIDEZ")]
        //public decimal? TgForceLiquidez { get; set; }

        //[Column("FK_CLUBE")]
        //public int? FkClube { get; set; }

        //[Column("TG_IMPBLOOMBERG")]
        //public decimal? TgImpBloomberg { get; set; }

        //[Column("TG_CONFBLOOMBERG")]
        //public decimal? TgConfBloomberg { get; set; }

        //[Column("DS_CHAVEBLOOMBERG")]
        //public string DsChaveBloomberg { get; set; }

        //[Column("DS_CLASS")]
        //public string DsClass { get; set; }

        //[Column("TG_BLOOMBERGACRUADO")]
        //public decimal? TgBloombergAcruado { get; set; }

        //[Column("FK_BLOOMBERGCONSULTA")]
        //public int? FkBloombergConsulta { get; set; }

        //[Column("DS_FKSBLOOMBERGCONSULTA")]
        //public string DsFksBloombergConsulta { get; set; }

        //[Column("TG_CONVESTRANGEIRO")]
        //public decimal? TgConvEstrangeiro { get; set; }

        //[Column("FK_MOEDALANC")]
        //public string FkMoedaLanc { get; set; }

        //[Column("TG_OUTRASMOEDAS")]
        //public decimal? TgOutrasMoedas { get; set; }

        //[Column("DS_TPCODBLOOMBERG")]
        //public string DsTpcodBloomberg { get; set; }

        //[Column("VL_FATORBRUTO")]
        //public decimal? VlFatorBruto { get; set; }

        //[Column("FK_CONJUNTO")]
        //public string FkConjunto { get; set; }

        //[Column("CD_CVM")]
        //public int? CdCvm { get; set; }

        //[Column("TG_FORWARD")]
        //public byte? TgForward { get; set; }

        //[Column("TG_CRAVARVALOREXTRATO")]
        //public decimal? TgCravarValorExtrato { get; set; }

        //[Column("DT_INICIO")]
        //public DateTime? DtInicio { get; set; }

        //[Column("TG_NAOCALCRENTAB")]
        //public decimal? TgNaoCalcRentab { get; set; }

        //[Column("TG_ATIVOBASEPROC")]
        //public decimal? TgAtivoBaseProc { get; set; }

        //[Column("FK_CUSTODIANTE")]
        //public int? FkCustodiante { get; set; }

        #endregion

    }
}
