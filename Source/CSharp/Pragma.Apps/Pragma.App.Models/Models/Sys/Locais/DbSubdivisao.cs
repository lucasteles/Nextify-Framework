
using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    //// [PgmDataBase(Connection = "HomologIntraConnection")]
    [Table("TCLUSUBDIVISAO")]
    public class DbSubdivisao : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        public int Id { get; set; }

        [Column("FK_PAIS")]
        public string FkPais { get; set; }
        [ForeignKey(nameof(FkPais))]
        public virtual DbPaisNovo Pais { get; set; }

        [Column("CD_ISO")]
        public string Codigo { get; set; }

        [Column("DS_NOME")]
        public string Nome { get; set; }

    }
}
