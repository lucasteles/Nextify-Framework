using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUTIPOATIVOCONTROLE")]
    public class DbAtivoTipoControle : BaseModel, IModelWithKey
    {

        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód.")]
        public int Id { get; set; }

        /// <summary>
        /// Lista de códigos de DbTivoAtivo como uma String separada por virgula.
        /// </summary>
        [Column("DS_TIPOATIVO")]
        [PgmColumn(DisplayText = "Lista Cód. TipoAtivo")]
        public string DsTipoAtivoLista { get; set; }

        [PgmColumn(DisplayText = "Tipo Ativo")]
        [Column("DS_TIPOATIVOCONTROLE")]
        public string Nome { get; set; }

        /// <summary>
        /// Propriedade utilizada em conciliações para verificação de variação (rentabilidade) máxima diária admitida.
        /// </summary>
        [Column("VL_VARIACAOMAX")]
        [PgmColumn(DisplayText = "Var. Máxima")]
        public decimal? VlVariacaoMaxima { get; set; }

    }
}

