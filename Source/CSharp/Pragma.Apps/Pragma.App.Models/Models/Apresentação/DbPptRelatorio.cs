
using Pragma.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUPPTRELATORIO")]
    public class DbPptRelatorio : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        public int Id { get; set; }
        [Column("DS_NOME")]
        [PgmColumn(DisplayText = "Nome da Apresentação")]
        public string Nome { get; set; }
        [Column("DS_SUFIXO")]
        [PgmColumn(DisplayText = "Sufixo da Apresentação")]
        public string Sufixo { get; set; }
        [PgmColumn(DisplayText = "Lista de paginas")]
        public ICollection<DbPptRelatorioPagina> ListPaginas { get; set; }

    }
}
