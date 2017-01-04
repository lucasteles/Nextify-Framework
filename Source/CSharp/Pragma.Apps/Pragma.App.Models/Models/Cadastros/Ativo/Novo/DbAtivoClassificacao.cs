
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Pragma.Core;

namespace Pragma.App.Model
{
    [Table("TCLUATIVOCLASSIFICACAO")]
    public class DbAtivoClassificacao : BaseModel, IModelWithKey
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

        [Column("FK_ATIVOCLASSE")]
        [PgmColumn(DisplayText = "Cód Classe")]
        public int FkAtivoClasse { get; set; }
        [ForeignKey(nameof(FkAtivoClasse))]
        public virtual DbAtivoClasse AtivoClasse { get; set; }

        [Column("FK_ATIVOSUBCLASSE")]
        [PgmColumn(DisplayText = "Cód Sub.Classe")]
        public int FkAtivoSubClasse { get; set; }
        [ForeignKey(nameof(FkAtivoSubClasse))]
        public virtual DbAtivoSubClasse AtivoSubClasse { get; set; }

        [Column("FK_ATIVOCONJUNTO")]
        [PgmColumn(DisplayText = "Cód Conjunto")]
        public string FkAtivoConjunto { get; set; }
        [ForeignKey(nameof(FkAtivoConjunto))]
        public virtual DbAtivoConjunto AtivoConjunto { get; set; }

    }
}