using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUCLASSE")]
    public class DbAtivoSubClasse : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód.")]
        [PgmF4(Show = true)]
        public int Id { get; set; }

        [Column("DS_CLASSE")]
        [PgmColumn(DisplayText = "Sub.Classe")]
        [PgmF4(Show = true)]
        public string DsSubClasse { get; set; }

        /// <summary>
        /// Propriedade utilizada em conciliações para verificação de variação (rentabilidade) máxima diária admitida.
        /// </summary>
        [Column("VL_VARIACAOMAX")]
        [PgmColumn(DisplayText = "Var. Máxima")]
        public decimal? VlVariacaoMaxima { get; set; }

    }
}
