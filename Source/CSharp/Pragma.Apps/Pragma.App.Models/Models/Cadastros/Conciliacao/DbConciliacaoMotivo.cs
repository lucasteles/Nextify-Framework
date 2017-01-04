
using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    // // [PgmDataBase(Log = true)]
    [Table("TCLUCONCILIACAOMOTIVO")]
    public class DbConciliacaoMotivo : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Código")]
        public int Id { get; set; }

        [Column("DS_NOME")]
        [PgmColumn(DisplayText = "Nome")]
        public string Nome { get; set; }

        [Column("DS_DESCRICAO")]
        [PgmColumn(DisplayText = "Descrição Padrão")]
        public string Descricao { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
