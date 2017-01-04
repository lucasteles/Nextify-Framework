
using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    //// [PgmDataBase(Connection = "HomologIntraConnection")]
    [Table("TCLUCIDADE")]
    public class DbCidadeNovo : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        public int Id { get; set; }

        [Column("FK_PAIS")]
        public string FkPais { get; set; }
        [ForeignKey(nameof(FkPais))]
        public virtual DbPaisNovo Pais { get; set; }

        [Column("FK_SUBDIVISAO")]
        public int? FkSubdivisao { get; set; }
        [ForeignKey(nameof(FkSubdivisao))]
        public virtual DbSubdivisao Subdivisao { get; set; }

        [Column("DS_NOME")]
        public string Nome { get; set; }

    }
}
