using Pragma.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUCOTFUNDO")]
    public class DbFundoCotacao : BaseModel, IModelWithKey<decimal>
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        public decimal Id { get; set; }

        [Column("FK_ATIVO")]
        [PgmColumn(DisplayText = "Cód. Ativo")]
        [StringLength(12)]
        public string FkAtivo { get; set; }
        [ForeignKey(nameof(FkAtivo))]
        public virtual DbInvestAtivo Ativo { get; set; }

        [ForeignKey(nameof(FkAtivo))]
        public virtual DbIndice Indice { get; set; }

        [Column("DT_COTACAO")]
        public DateTime DtCotacao { get; set; }

        [Column("VL_COTACAO")]
        public decimal VlCotacao { get; set; }

        [Column("VL_PL")]
        public decimal VlPatrimonio { get; set; }

        [Column("DS_INDEXADOR")]
        public string DsIndexador { get; set; }

        [Column("TG_ALTERAR")]
        public decimal TgAlterar { get; set; }

    }
}
