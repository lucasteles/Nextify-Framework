using Pragma.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUFECHAMENTO")]
    public class DbFechamento : BaseModel, IModelWithKey<decimal>
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód.")]
        public decimal Id { get; set; }

        [Column("FK_CLUBE")]
        [PgmColumn(DisplayText = "Cód Investimento")]
        public decimal FkInvestimento { get; set; }
        [ForeignKey(nameof(FkInvestimento))]
        public virtual DbInvestimento Investimento { get; set; }
        [Column("DT_ULTFECH")]
        [PgmColumn(DisplayText = "Ult. Fech")]
        public DateTime DtUltFech { get; set; }

        [Column("VL_COTASD0")]
        [PgmColumn(DisplayText = "Vl. Cotas D-0")]
        public decimal VlCotasD0 { get; set; }

        [Column("QT_COTASD0")]
        [PgmColumn(DisplayText = "Qt. Cotas D-0")]
        public decimal QtCotasD0 { get; set; }

        [Column("VL_PLD0")]
        [PgmColumn(DisplayText = "PL D-0")]
        public decimal VlPlD0 { get; set; }

        #region XML 5.0 De/Para

        //[Key]
        //[Column("PK_ID")]
        //public decimal Id { get; set; }

        //[Column("FK_CLUBE")]
        //public decimal? FkClube { get; set; }

        //[Column("DT_ULTFECH")]
        //public DateTime DtUltFech { get; set; }

        [Column("DT_D0")]
        public DateTime? DtD0 { get; set; }

        //[Column("VL_COTASD0")]
        //public decimal VlCotasD0 { get; set; }

        //[Column("QT_COTASD0")]
        //public decimal QtCotasD0 { get; set; }

        [Column("VL_PLD0BRU")]
        public decimal VlPlD0Bru { get; set; }

        //[Column("VL_PLD0")]
        //public decimal VlPlD0 { get; set; }

        //[Column("VL_TXPERD0")]
        //public decimal VlTxperD0 { get; set; }

        //[Column("VL_TXADMD0")]
        //public decimal VlTxadmD0 { get; set; }

        //[Column("VL_FUTURASD0")]
        //public decimal VlFuturasD0 { get; set; }

        [Column("VL_COTABRUD0")]
        public decimal VlCotaBruD0 { get; set; }

        //[Column("VL_TXPRESGD0")]
        //public decimal VlTxpresgD0 { get; set; }

        //[Column("VL_APLICBLOQD0")]
        //public decimal VlAplicBloqD0 { get; set; }

        [Column("VL_CARTEIRAD0")]
        public decimal? VlCarteiraD0 { get; set; }

        //[Column("VL_TESOURARIAD0")]
        //public decimal? VlTesourariaD0 { get; set; }

        //[Column("QT_COTISTAS")]
        //public decimal QtCotistas { get; set; }

        //[Column("VL_PORRENT")]
        //public decimal VlPorrent { get; set; }

        [Column("VL_PLNAC")]
        public decimal? VlPlNac { get; set; }

        //[Column("VL_PLOFF")]
        //public decimal? VlPlOff { get; set; }

        //[Column("VL_PLANTERIOR")]
        //public decimal? VlPlAnterior { get; set; }

        [Column("VL_MOVDODIA")]
        public decimal VlMovDoDia { get; set; }

        //[Column("VL_COTARENT")]
        //public decimal? VlCotaRent { get; set; }

        //[Column("VL_COTABRUTOT")]
        //public decimal? VlCotaBrutoT { get; set; }

        //[Column("TG_PROCESSADO")]
        //public decimal? TgProcessado { get; set; }

        //[Column("VL_PORRENTBRU")]
        //public decimal? VlPorrentBru { get; set; }

        //[Column("VL_PLBRUANT")]
        //public decimal? VlPlBruAnt { get; set; }

        //[Column("VL_TXADMDIA")]
        //public decimal? VlTxAdmDia { get; set; }

        //[Column("VL_MOVTXDIA")]
        //public decimal? VlMovTxDia { get; set; }

        //[Column("VL_PLD0BRU_BAK")]
        //public decimal? VlPlD0BruBak { get; set; }

        //[Column("VL_COTREAL")]
        //public decimal? VlCotReal { get; set; }

        //[Column("TG_VIRADAPERF")]
        //public byte? TgViradaPerf { get; set; }

        //[Column("VL_SWAPDOLAR")]
        //public decimal? VlSwapDolar { get; set; }

        //[Column("VL_SWAPREAL")]
        //public decimal? VlSwapReal { get; set; }

        //[Column("VL_MOVSEMIMPAC")]
        //public decimal? VlMovSemImpac { get; set; }

        //[Column("VL_TXGESD0")]
        //public decimal? VlTxGesD0 { get; set; }

        //[Column("VL_FUTURASOFFD0")]
        //public decimal? VlFuturasOffD0 { get; set; }

        //[Column("VL_TXGESDIA")]
        //public decimal? VlTxGesDia { get; set; }

        #endregion

        /* TODO: Map this
             oModelBuilder.Entity<DbFechamento>().Property(i => i.QtCotasD0).HasPrecision(20, 8);
             oModelBuilder.Entity<DbFechamento>().Property(i => i.VlCotasD0).HasPrecision(16, 8);
             oModelBuilder.Entity<DbFechamento>().Property(i => i.VlPlD0).HasPrecision(14, 2);
         */
    }
}
