
using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUTIPOCLUBE")]
    public class DbInvestimentoTipo : BaseModel, IModelWithKey<decimal>
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód.")]
        [PgmF4(Show = true)]
        public decimal Id { get; set; }

        [Column("DS_TIPOCLUBE")]
        [PgmColumn(DisplayText = "Tipo de Investimento")]
        [PgmF4(Show = true)]
        public string DsTipoInvestimento { get; set; }

    }
}