
using Pragma.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model.Sys
{
    [Table("TSISUSULOG")]
    // // [PgmDataBaseAttribute(Connection = "HomologIntraConnection")]
    public class DbLogUsuario : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        public int Id { get; set; }

        [Column("FK_USULOGIN")]
        public int? FkUsuLogin { get; set; }

        [Column("DH_ACAO")]
        public DateTime DhAcao { get; set; }

        [Column("DS_MAQUINA")]
        public string DsMaquina { get; set; }

        [Column("DS_LOGONREDE")]
        public string DsLogonRede { get; set; }

        [Column("TG_AMBIENTE")]
        public decimal? TgAmbiente { get; set; }

        [Column("DS_DATABASE")]
        public string DsDatabase { get; set; }

        [Column("DS_ID")]
        public string DsId { get; set; }

        [Column("DS_ROTINA")]
        public string DsRotina { get; set; }

        [Column("TG_ACAO")]
        public char? TgAcao { get; set; }

        [Column("DS_TABELA")]
        public string DsTabela { get; set; }

        [Column("DS_DADOSACAO")]
        public string DsDadosAcao { get; set; }

    }
}
