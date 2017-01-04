using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TSISUSULOGINGRUPO")]
    // // [PgmDataBaseAttribute(Connection = PgmGlobal.SysConnectionName)]
    public class DbUsuarioLoginGrupo : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        public int Id { get; set; }
        [Column("FK_USULOGIN")]
        [PgmColumn(DisplayText = "Cód Usuário")]
        public int FkUsuLogin { get; set; }
        [ForeignKey(nameof(FkUsuLogin))]
        public virtual DbUsuarioLogin UsuLogin { get; set; }
        [Column("FK_USUGRUPO")]
        [PgmColumn(DisplayText = "Cód Grupo")]
        public int FkUsuGrupo { get; set; }
        [ForeignKey(nameof(FkUsuGrupo))]
        public virtual DbUsuarioGrupo UsuGrupo { get; set; }

    }
}
