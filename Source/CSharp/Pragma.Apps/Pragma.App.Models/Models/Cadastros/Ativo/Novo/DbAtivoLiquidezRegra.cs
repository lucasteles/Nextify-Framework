using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using Pragma.Core;

namespace Pragma.App.Model
{
    [Table("TCLUTIPOSREGRAPERIODO")]
    public class DbAtivoLiquidezRegra : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód.")]
        public int Id { get; set; }

        [Column("DS_REGRA")]
        [PgmColumn(DisplayText = "Regra")]
        public string Nome { get; set; }

    }
}
