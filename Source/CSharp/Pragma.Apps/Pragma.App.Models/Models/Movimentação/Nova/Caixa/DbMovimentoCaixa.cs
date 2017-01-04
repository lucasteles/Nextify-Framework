using Pragma.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUMOVIMENTOCAIXA")]
    public class DbMovimentoCaixa : AbstractMovimento, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        [PgmF4(Show = true)]
        public int Id { get; set; }

        [Column("DT_MOVIMENTO")]
        [PgmColumn(DisplayText = "Dt. Movimento")]
        [PgmF4(Show = true)]
        public DateTime DtMovimento { get; set; }

    }
}