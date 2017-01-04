using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using Pragma.Core;

namespace Pragma.App.Model
{
    [Table("TCLUCARTCONSLIQUIDEZ")]
    public class DbPublicadoLiquidez : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        public int Id { get; set; }

        [Column("FK_CARTCONS")]
        public int FkCartcons { get; set; }
        [ForeignKey(nameof(FkCartcons))]
        public virtual DbPublicadoIndice CartConsIndice { get; set; }

        [Column("DT_COTACAO")]
        public DateTime DtCotacao { get; set; }

        [Column("TG_LOCAL")]
        public decimal TgLocal { get; set; }

        [Column("FK_ATIVO")]
        public string FkAtivo { get; set; }
        [ForeignKey(nameof(FkAtivo))]
        public virtual DbInvestAtivo Ativo { get; set; }

        [Column("DS_VENCIMENTO")]
        public string DsVencimento { get; set; }

        [Column("CD_INTERNOGESTOR")]
        public string CdInternoGestor { get; set; }

        [Column("CD_OPCAO")]
        public string CdOpcao { get; set; }

        [Column("TG_TIPOLIQ")]
        public decimal TgTipoLiq { get; set; }

        [Column("VL_PATRCALC")]
        public decimal VlPatrCalculo { get; set; }

        [Column("NR_DIASLIQ")]
        public int NrDiasLiq { get; set; }

    }
}
