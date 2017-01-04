using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUCLUBEXCONTA")]
    public class DbClubeXConta : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        public int Id { get; set; }

        [PgmColumn(DisplayText = "Cód Investimento")]
        public decimal FkInvestimento { get; set; }
        [ForeignKey(nameof(FkInvestimento))]
        public virtual DbInvestimento Investimento { get; set; }

        [Column("FK_CONTA")]
        public decimal FkContaOld { get; set; }

        [Column("FK_CONTANEW")]
        public decimal FkConta { get; set; }

    }
}