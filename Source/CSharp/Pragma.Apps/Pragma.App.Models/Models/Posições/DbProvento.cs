using Pragma.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUPROVENTO")]
    public class DbProvento : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        public int Id { get; set; }

        [Column("FK_TIPOPROVENTO")]
        public short? FkTipoProvento { get; set; }

        [Column("FK_ATIVO")]
        public string FkAtivo { get; set; }
        [ForeignKey(nameof(FkAtivo))]
        public virtual DbInvestAtivo Ativo { get; set; }

        [Column("NR_DISTRIBUICAO")]
        public short? NrDistribuicao { get; set; }

        [Column("CD_ISIN")]
        public string CdIsin { get; set; }

        [Column("DT_APROVACAO")]
        public DateTime? DtAprovacao { get; set; }

        [Column("VL_PROVENTO")]
        public decimal? VlProvento { get; set; }

        [Column("VL_FATORGRUPO")]
        public decimal? VlFatorGrupo { get; set; }

        [Column("DT_PAGAMENTO")]
        public DateTime? DtPagamento { get; set; }

        [Column("TG_INDICADOR")]
        public string TgIndicador { get; set; }

        [Column("DT_COTACAO")]
        public DateTime? DtCotacao { get; set; }

        [Column("CD_IDENTIFICADOR")]
        public string CdIdentificador { get; set; }

        [Column("FK_FORMULA")]
        public int? FkFormula { get; set; }

        [Column("DS_VENCIMENTO")]
        public string DsVencimento { get; set; }

        [Column("FK_MOEDA")]
        public string FkMoeda { get; set; }

        [Column("TG_ORIGEM")]
        public string TgOrigem { get; set; }

        [Column("TG_IMPORTSEMCONF")]
        public int? TgImportSemConf { get; set; }

        [Column("VL_IMPDIVIDENDOS")]
        public decimal? VlImpDividendos { get; set; }

        [Column("TG_ORIREG")]
        public string TgOriReg { get; set; }

        [Column("TG_ALTERAR")]
        public decimal? TgAlterar { get; set; }

    }
}
