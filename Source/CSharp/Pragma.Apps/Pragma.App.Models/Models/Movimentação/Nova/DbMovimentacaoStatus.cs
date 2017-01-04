using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace Pragma.App.Model
{
    [Table("TCLUMOVIMENTOSTATUS")]
    public class DbMovimentacaoStatus : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        [PgmF4(Show = true)]
        public int Id { get; set; }

        [Column("DS_NOME")]
        [PgmColumn(DisplayText = "Status")]
        [PgmF4(Show = true)]
        public string Nome { get; set; }

        [Column("TG_APROVACAO")]
        [PgmColumn(DisplayText = "Aprovação?")]
        public bool Aprovacao { get; set; }

        [Column("NR_COR")]
        [PgmColumn(DisplayText = "Cor")]
        public int Cor { get; set; }

        public Color Color { get { return Color.FromArgb(Cor); } }

    }
}