using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("VCLUCOTSALDO")]
    public class DbCotSaldo : BaseModel, IModelWithKey<decimal>
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód.")]
        [PgmF4(Show = true)]
        public decimal Id { get; set; }

        [Column("FK_CLUBE")]
        [PgmColumn(DisplayText = "Cód Investimento")]
        public decimal FkInvestimento { get; set; }
        [ForeignKey(nameof(FkInvestimento))]
        public virtual DbInvestimento Investimento { get; set; }

        [Column("DT_ATUAL")]
        public System.DateTime DtAtual { get; set; }

        [Column("QT_ATUAL")]
        public decimal? QtAtual { get; set; }

        [Column("VL_APLICBLOQD0")]
        public decimal VlAplicBloqD0 { get; set; }

        [Column("VL_BRUTO")]
        public decimal VlBruto { get; set; }

        [Column("VL_LIQUIDO")]
        public decimal VlLiquido { get; set; }

        [Column("VL_IRRF")]
        public decimal VlIrrf { get; set; }

        [Column("VL_IOF")]
        public decimal VlIof { get; set; }

        [Column("VL_RENDIMENTO")]
        public decimal? VlRendimento { get; set; }

        [Column("CD_CLIENTE")]
        public decimal FkContaOld { get; set; }

        [Column("NR_CNPJ")]
        public decimal? NrCnpj { get; set; }

        [Column("DS_RAZAO")]
        [PgmColumn(DisplayText = "Razão")]
        public string Razao { get; set; }

    }
}
