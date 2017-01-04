using Pragma.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUMOVIMENTOEVENTO")]
    public class DbMovimentacaoEvento : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        [PgmF4(Show = true)]
        public int Id { get; set; }

        [Column("DT_MOVIMENTOEVENTO")]
        [PgmColumn(DisplayText = "Dt. Evento Movimento")]
        [PgmF4(Show = true)]
        public DateTime DtMovimento { get; set; }

        public virtual ICollection<DbMovimentoAtivo> ListMovimentoAtivo { get; set; }
        //public virtual ICollection<DbMovimentoPassivo> ListMovimentoPassivo { get; set; }
        //public virtual ICollection<DbMovimentoCaixa> ListMovimentoCaixa { get; set; }

    }
}