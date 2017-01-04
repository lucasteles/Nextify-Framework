using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Pragma.Core;

namespace Pragma.App.Model.Posições
{
    [Table("TCLUCOTAESPECIAL")]
    public class DbCotaEspecial : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        public int Id { get; set; }

        [Column("DT_CARTEIRA")]
        public System.DateTime DtPosicao { get; set; }

        [Column("VL_COTAESPECIAL")]
        public decimal VlCotaespecial { get; set; }

        [Column("FK_ATIVO")]
        public string FkAtivo { get; set; }
        [ForeignKey(nameof(FkAtivo))]
        public virtual DbInvestAtivo Ativo { get; set; }

    }
}
