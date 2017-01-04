
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Pragma.Core;

namespace Pragma.App.Model
{
    [Table("TCLUFORMALIQUIDACAO")]
    public class DbLiquidacaoForma : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Forma de Liquidação")]
        [PgmF4(Show = true)]
        public int Id { get; set; }

        [PgmF4(Show = true)]
        public virtual string Nome{get{ return FkLiquidacaoModo.Trim() + "|" + FkLiquidacaoTipo.Trim(); }}

        [Column("FK_MODOLIQUIDACAO")]
        [PgmColumn(DisplayText = "Modo Liquidação")]
        public string FkLiquidacaoModo { get; set; }
        [ForeignKey(nameof(FkLiquidacaoModo))]
        public virtual DbLiquidacaoModo LiquidacaoModo { get; set; }

        [Column("FK_TIPOLIQATIVO")]
        [PgmColumn(DisplayText = "Tipo Liquidação")]
        public string FkLiquidacaoTipo { get; set; }
        [ForeignKey(nameof(FkLiquidacaoTipo))]
        public virtual DbLiquidacaoTipo LiquidacaoTipo { get; set; }

    }
}