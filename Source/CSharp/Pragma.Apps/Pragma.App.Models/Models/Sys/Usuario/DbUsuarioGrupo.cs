using Pragma.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TSISUSUGRUPO")]
    // // [PgmDataBaseAttribute(Connection = PgmGlobal.SysConnectionName)]
    public class DbUsuarioGrupo : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        public int Id { get; set; }
        [Column("DS_NOME")]
        [PgmColumn(DisplayText = "Nome")]
        public string Login { get; set; }
        [Column("TG_ADMCLUBE")]
        [PgmColumn(DisplayText = "Adm.Investimento")]
        public decimal AdmInvestimento { get; set; }
        [Column("TG_ADMMENUSISTEMA")]
        [PgmColumn(DisplayText = "Adm.Menu Sistema")]
        public decimal AdmMenuSistema { get; set; }
        [Column("TG_ADMAPROVACAO")]
        [PgmColumn(DisplayText = "Adm. Aprovação")]
        public decimal AdmAprovacao { get; set; }
        public ICollection<DbUsuarioLoginGrupo> ListUsers { get; set; }

    }
}
