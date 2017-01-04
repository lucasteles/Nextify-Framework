using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUCADATIVOLIQUIDEZ")]
    public class DbAtivoLiquidez : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód.")]
        public int Id { get; set; }

        [Column("FK_ATIVO")]
        public string FkAtivo { get; set; }
        [ForeignKey(nameof(FkAtivo))]
        public virtual DbInvestAtivo Ativo { get; set; }

        [Column("TG_TIPO")]
        [PgmColumn(DisplayText = "Tipo")]
        public decimal TgTipo { get; set; }

        [Column("NR_DIAS")]
        [PgmColumn(DisplayText = "Nr.Dias")]
        public decimal NrDias { get; set; }

        [Column("TG_OPERACAO")]
        [PgmColumn(DisplayText = "Operação")]
        public decimal TgOperacao { get; set; }

        [Column("FK_ATIVOLIQUIDEZREGRA")]
        [PgmColumn(DisplayText = "Regra")]
        public int FkAtivoLiquidezRegra { get; set; }
        [ForeignKey(nameof(FkAtivoLiquidezRegra))]
        public virtual DbAtivoLiquidezRegra AtivoLiquidezRegra { get; set; }

        [Column("DS_MESES")]
        [PgmColumn(DisplayText = "Hash Mês")]
        public string DsMeses { get; set; }

    }
}
