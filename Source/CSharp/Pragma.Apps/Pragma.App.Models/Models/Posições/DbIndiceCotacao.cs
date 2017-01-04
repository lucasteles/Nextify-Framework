using Pragma.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUINDICECOTACAO")]
    public class DbIndiceCotacao : BaseModel, IModelWithKey<int>
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        public int Id { get; set; }

        [Column("FK_INDICE")]
        [PgmColumn(DisplayText = "Cód. Indice")]
        [StringLength(12)]
        public string FkIndice { get; set; }

        [ForeignKey(nameof(FkIndice))]
        public virtual DbIndice Indice { get; set; }

        [Column("DT_COTACAO")]
        public DateTime DtCotacao { get; set; }

        [Column("VL_COTACAO")]
        public decimal VlCotacao { get; set; }

        [Column("VL_COTACAOMED")]
        public decimal VlCotacaoMed { get; set; }

        [Column("TG_PREVIA")]
        public decimal TgPrevia { get; set; }

    }
}
