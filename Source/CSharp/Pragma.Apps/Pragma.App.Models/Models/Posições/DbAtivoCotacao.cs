using Pragma.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("VCLUCOTACAO_NET")]
    public class DbAtivoCotacao : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        public int Id { get; set; }

        [Column("TG_TIPO")]
        public string Tipo { get; set; }

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

        [Column("DT_VENCIMENTO")]
        public DateTime? DtVencimento { get; set; }

        [Column("DS_VENCIMENTO")]
        public string DsVencimento { get; set; }

        [Column("VL_COTACAO")]
        public decimal VlCotacao { get; set; }

        [Column("VL_COTACAOMED")]
        public decimal VlCotacaoMed { get; set; }

        [Column("QT_VOLUMENEG")]
        public decimal QtVolume { get; set; }

        [Column("VL_MARGEM")]
        public decimal VlMargem { get; set; }

        [Column("TG_PREVIA")]
        public decimal TgPrevia { get; set; }

    }
}
