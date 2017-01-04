
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Pragma.Core;

namespace Pragma.App.Model
{
    [Table("TCLUCONFERENCIA")]
    public class DbConferencia : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód.")]
        [PgmF4(Show = true)]
        public int Id { get; set; }

        [Column("DS_NOME")]
        [PgmColumn(DisplayText = "Nome")]
        [PgmF4(Show = true)]
        public string Nome { get; set; }

        [Column("DS_CLASSE")]
        [PgmColumn(DisplayText = "Assembly Qualified Name")]
        public string Classe { get; set; }

    }
}
