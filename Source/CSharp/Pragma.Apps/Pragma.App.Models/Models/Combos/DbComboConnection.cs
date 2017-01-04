using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("COMBO_CONNECTION")]
    public class DbComboConnection : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        public int Id { get; set; }

        [Column("DS_DISPLAYMEMBER")]
        public string DisplayMember { get; set; }

        [Column("DS_VALUEMEMBER")]
        public string ValueMember { get; set; }

        [Column("NR_ORDEM")]
        public byte Ordem { get; set; }
    }
}
