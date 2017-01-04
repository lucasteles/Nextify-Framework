using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TSISUSUEXTERNO")]
    // // [PgmDataBaseAttribute(Connection = PgmGlobal.SysConnectionName)]
    public class DbUsuExterno : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        public int Id { get; set; }

        [Column("DS_NOME")]
        [PgmColumn(DisplayText = "Nome")]
        public string Nome { get; set; }

        [Column("DS_LOGIN")]
        [PgmColumn(DisplayText = "Login")]
        public string Login { get; set; }

        [Column("DS_SENHA")]
        [PgmColumn(DisplayText = "Senha")]
        public string Senha { get; set; }

        [Column("FK_USULOGIN")]
        public int FkUsulogin { get; set; }
        [ForeignKey(nameof(FkUsulogin))]
        public virtual DbUsuarioLogin UsuLogin { get; set; }

        [Column("FK_USUEXTERNOORIGEM")]
        [PgmColumn(DisplayText = "Cód. Origem Externa")]
        public int FkOrigem { get; set; }
        [ForeignKey(nameof(FkOrigem))]
        public virtual DbOrigemExterna OrigemExterna { get; set; }

    }
}