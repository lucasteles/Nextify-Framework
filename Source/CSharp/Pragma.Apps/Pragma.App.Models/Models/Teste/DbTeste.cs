using Pragma.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUTESTE")]
    public class DbTeste : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        public int Id { get; set; }

        [Column("DS_EXEMPLO")]
        [PgmColumn(DisplayText = "Desc. Teste")]
        public string Desc { get; set; }

        [Column("VL_EXEMPLO")]
        [PgmColumn(DisplayText = "Vl. Teste")]
        public decimal Valor { get; set; }

        [Column("DT_EXEMPLO")]
        [PgmColumn(DisplayText = "Dt. Teste")]
        public DateTime? Data { get; set; }

        public virtual ICollection<DbExemplo> Exemplos { get; set; }

    }
}
