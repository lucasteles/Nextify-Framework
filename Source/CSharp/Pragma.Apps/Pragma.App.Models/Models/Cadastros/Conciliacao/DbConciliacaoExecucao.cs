
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Pragma.Core;

namespace Pragma.App.Model
{
    [Table("TCLUCONCILIACAOEXECUCAO")]
    public class DbConciliacaoExecucao : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        public int Id { get; set; }

        [Column("FK_TIPOINVESTIMENTO")]
        public decimal FkTipoInvestimento { get; set; }

        [Column("FK_PORTIFOLIO")]
        public string FkPortifolio { get; set; }

        [Column("DT_INICIAL")]
        public DateTime DtInicial { get; set; }

        [Column("DT_FINAL")]
        public DateTime DtFinal { get; set; }

    }
}
