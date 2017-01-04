
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Pragma.Core;

namespace Pragma.App.Model
{
    [Table("TCLUCONCILIACAOERRO")]
    public class DbConciliacaoErro : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        public int Id { get; set; }

        [Column("DS_ERRO")]
        public string Descricao { get; set; }

        [Column("NR_PRIORIDADE")]
        public int Prioridade { get; set; }

    }
}
