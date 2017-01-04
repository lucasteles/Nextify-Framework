using Pragma.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUMANDATO")]
    public class DbMandato : BaseModel, IModelWithKey<string>
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód.")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }

        [Column("DS_MANDATO")]
        [PgmColumn(DisplayText = "Mandato")]
        public string DsMandato { get; set; }

        public virtual ICollection<DbInvestimento> ListInvestimento { get; set; }

        public virtual ICollection<DbMandatoItem> ListMandatoItem { get; set; }

    }
}
