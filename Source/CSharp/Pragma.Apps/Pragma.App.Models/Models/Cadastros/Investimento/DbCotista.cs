using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{

    [Table("TCLUCOTISTA")]
    public class DbCotista : BaseModel, IModelWithKey<decimal>
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

        [Column("FK_CONTA")]
        public int FkConta { get; set; }

        [Column("CD_CLIENTE")]
        public decimal FkContaOld { get; set; }
        /// <summary>
        /// Flag indica se o cotista é isento (True) ou não (False) de imposto de renda. 
        /// Caso o passivo do fundo fosse processado pelo Invest, esta flag iria impedir o cálculod e estoque de iR sobre a psoição do cliente.
        /// </summary>
        [Column("TG_ISENTO")]
        public decimal? TgIsentoImposto { get; set; }
        /// <summary>
        /// Esta flag indica se o estoque de cotas deve (False) ou não (True) ser utiliza por Investimentos processados (que utilizam o vínculo de passivo)
        /// </summary>
        [Column("TG_NAOUTILIZARPOSICAO")]
        public decimal? TgNaoUtilizarPassivo { get; set; }

    }
}