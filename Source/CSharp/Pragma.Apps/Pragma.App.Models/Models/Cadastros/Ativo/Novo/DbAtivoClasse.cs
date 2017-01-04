using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUSETOR")]
    public class DbAtivoClasse : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód.")]
        [PgmF4(Show = true)]
        public int Id { get; set; }

        [PgmColumn(DisplayText = "Cód")]
        public string SId { get { return Id.ToString().PadLeft(4, '0'); } }

        [Column("DS_SETOR")]
        [PgmColumn(DisplayText = "Classe")]
        [PgmF4(Show = true)]
        public string DsClasse { get; set; }

        [Column("NR_CORFUNDO")]
        [PgmColumn(DisplayText = "CorFundo")]
        public int CorFundo { get; set; }

        [Column("NR_CORLEGENDA")]
        [PgmColumn(DisplayText = "CorLegenda")]
        public int CorLegenda { get; set; }

        [Column("NR_ORDEM")]
        [PgmColumn(DisplayText = "NrOrdem")]
        public int NrOrdem { get; set; }

        [Column("CD_EXPORTARXLS")]
        [PgmColumn(DisplayText = "CdExportarXls")]
        public string ExportarXls { get; set; }

        [Column("FK_APINDICELOC")]
        [PgmColumn(DisplayText = "FkApindiceLoc")]
        public string FkApindiceLoc { get; set; }
        [ForeignKey(nameof(FkApindiceLoc))]
        public virtual DbIndice IndiceLoc { get; set; }

        [Column("FK_APINDICEOFF")]
        [PgmColumn(DisplayText = "FkApindiceOff")]
        public string FkApindiceOff { get; set; }
        [ForeignKey(nameof(FkApindiceOff))]
        public virtual DbIndice IndiceOff { get; set; }

        [Column("FK_APINDICECOM")]
        [PgmColumn(DisplayText = "FkApindiceCom")]
        public string FkApindiceCom { get; set; }
        [ForeignKey(nameof(FkApindiceCom))]
        public virtual DbIndice IndiceCom { get; set; }

        [Column("FK_APINDICECOMOFF")]
        [PgmColumn(DisplayText = "FkApindiceComOff")]
        public string FkApindiceComOff { get; set; }
        [ForeignKey(nameof(FkApindiceComOff))]
        public virtual DbIndice IndiceComOff { get; set; }

        [Column("TG_OCULTAR")]
        [PgmColumn(DisplayText = "TgOcultar")]
        public decimal TgOcultar { get; set; }

        [Column("TG_NAOCALCRENTAB")]
        [PgmColumn(DisplayText = "TgNaoCalcRentab")]
        public decimal? TgNaoCalcRentab { get; set; }

        [Column("DS_CLASSES")]
        public string DsClasses { get; set; }

        /// <summary>
        /// Propriedade utilizada em conciliações para verificação de variação (rentabilidade) máxima diária admitida.
        /// </summary>
        [Column("VL_VARIACAOMAX")]
        [PgmColumn(DisplayText = "Var. Máxima")]
        public decimal? VlVariacaoMaxima { get; set; }

    }
}
