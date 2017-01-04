using Pragma.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TSISUSULOGIN")]
    // [PgmDataBase(Connection = PgmGlobal.SysConnectionName)]
    public class DbUsuarioLogin : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        public int Id { get; set; }

        [Column("DS_LOGIN")]
        [PgmColumn(DisplayText = "Login")]
        public string Login { get; set; }

        [Column("DS_NOME")]
        [PgmColumn(DisplayText = "Nome")]
        public string Nome { get; set; }

        [Column("DS_SENHA")]
        [PgmColumn(DisplayText = "Senha")]
        public string Senha { get; set; }

        [Column("DS_EMAIL")]
        [PgmColumn(DisplayText = "Email")]
        public string Email { get; set; }

        [PgmColumn(DisplayText = "Lista de Grupos")]
        public ICollection<DbUsuarioLoginGrupo> ListGrups { get; set; }

    }
}
