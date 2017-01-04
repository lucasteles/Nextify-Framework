using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Pragma.Core;

namespace Pragma.App.Model.Posições
{
    [Table("TCLUESTCOTA")]
    public class DbEstCota : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        public int Id { get; set; }

        [Column("FK_CLUBE")]
        public decimal FkInvestimento { get; set; }

        [Column("FK_COTISTA")]
        public int FkCotista { get; set; }

        [Column("DT_ATUAL")]
        public System.DateTime DtAtual { get; set; }

        [Column("QT_ATUAL")]
        public decimal QtAtual { get; set; }

        [Column("VL_BRUTO")]
        public decimal VlBruto { get; set; }

        [Column("VL_LIQUIDO")]
        public decimal VlLiquido { get; set; }

        [Column("VL_IRRF")]
        public decimal VlIrrf { get; set; }

        [Column("VL_IOF")]
        public decimal VlIof { get; set; }

        [Column("QT_APLICACAO")]
        public decimal? QtAplicacao { get; set; }

        [Column("DT_APLICACAO")]
        public System.DateTime DtAplicacao { get; set; }

        [Column("DT_IRRF")]
        public System.DateTime DtIrrf { get; set; }

        [Column("DT_PERFORMANCE")]
        public System.DateTime? DtPerformance { get; set; }

        [Column("VL_COTAAPL")]
        public decimal? VlCotaapl { get; set; }

        [Column("VL_COTAIRRF")]
        public decimal? VlCotairrf { get; set; }

        [Column("VL_COTAPERF")]
        public decimal? VlCotaperf { get; set; }

        [Column("VL_IRRFANT")]
        public decimal VlIrrfant { get; set; }

        [Column("VL_PERFORMANCEBASE")]
        public decimal VlPerformancebase { get; set; }

        [Column("VL_PERFORMANCEPROV")]
        public decimal VlPerformanceprov { get; set; }

        [Column("DH_ENVREM")]
        public System.DateTime? DhEnvrem { get; set; }

        [Column("DH_ENVRET")]
        public System.DateTime? DhEnvret { get; set; }

        [Column("NR_CAUTELA")]
        public int? NrCautela { get; set; }

        [Column("VL_COTA")]
        public decimal? VlCota { get; set; }

    }
}
