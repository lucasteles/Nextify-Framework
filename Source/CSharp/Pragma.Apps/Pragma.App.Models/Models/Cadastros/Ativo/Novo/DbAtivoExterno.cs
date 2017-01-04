using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUATIVOCODEXTERNO")]
    public class DbAtivoExterno : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód.")]
        public int Id { get; set; }

        [Column("FK_ATIVO")]
        [PgmColumn(DisplayText = "Cód. Ativo")]
        [StringLength(12)]
        public string FkAtivo { get; set; }
        [ForeignKey(nameof(FkAtivo))]
        public virtual DbInvestAtivo Ativo { get; set; }

        [Column("DS_DESCEXTERNO")]
        [PgmColumn(DisplayText = "Nome")]
        public string Nome { get; set; }

        [Column("CD_EXTERNO")]
        [PgmColumn(DisplayText = "Codigo")]
        public string Codigo { get; set; }

        [Column("FK_INSTITUICAO")]
        [PgmColumn(DisplayText = "Cód. Instituição")]
        public int? FkInstituicao { get; set; }
        [ForeignKey(nameof(FkInstituicao))]
        public virtual DbEmpresaInstituicao Instituicao { get; set; }

    }
}
