using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using Pragma.Core;

namespace Pragma.App.Model
{
    [Table("TCLUTIPOATIVO")]
    public class DbAtivoTipo : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód.")]
        [PgmF4(Show = true)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Column("DS_TIPOATIVO")]
        [PgmColumn(DisplayText = "Tipo Ativo")]
        [PgmF4(Show = true)]
        public string Nome { get; set; }

        [Column("FK_TIPOATIVOCONTROLE")]
        [PgmColumn(DisplayText = "Cód Tipo Ativo Controle")]
        public int FkTipoAtivoControle { get; set; }
        [ForeignKey(nameof(FkTipoAtivoControle))]
        public virtual DbAtivoTipoControle TipoAtivoControle { get; set; }

        /// <summary>
        /// Propriedade utilizada em conciliações para verificação de variação (rentabilidade) máxima diária admitida.
        /// </summary>
        [Column("VL_VARIACAOMAX")]
        [PgmColumn(DisplayText = "Var. Máxima")]
        public decimal? VlVariacaoMaxima { get; set; }

    }
}
