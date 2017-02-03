using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.Core
{
    public abstract class BaseModel : IBase
    {
        [Column("TG_INATIVO")]
        public decimal? Inativo { get; set; }

        [Column("FK_OWNER")]
        public int? Owner { get; set; }

        [Column("DH_INCLUSAO")]
        public DateTime? DhInclusao { get; set; }

        [Column("DH_ALTERACAO")]
        public DateTime? DhAlteracao { get; set; }

        public bool IsInative() => Inativo == 1;

    }
}
