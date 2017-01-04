using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Pragma.Core;

namespace Pragma.App.Model
{
    [Table("TCLUDESCLANCAMENTO")]
    public class DbPagRecDescricao : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        public int Id { get; set; }

        [Column("DS_LANCAMENTO")]
        public string Nome { get; set; }

        /// <summary>
        /// Flag indicativa se o lançamento poderá ser um  (C)rédito, (D)ébito ou os dois. 
        /// </summary>
        [Column("TG_DC2")]
        public string TgDc { get; set; }

        [Column("TG_DESCONSIDERAR")]
        public byte? TgDesconsiderar { get; set; }

        /// <summary>
        /// Indica os possiveis códigos de associação com Proventos (Dividnedos, Amortizações etc) que a importação FTP Bloomberg.
        /// </summary>
        [Column("DS_PROVENTOBLOOMBERG")]
        public string DsProventoBloomberg { get; set; }

        [Column("TG_DUPLICARLANCAMENTO")]
        public decimal? TgDuplicarLancamento { get; set; }

        [Column("TG_PROVISAO")]
        public decimal? TgProvisao { get; set; }

        [Column("TG_CAMBIO")]
        public decimal? TgCambio { get; set; }

    }
}
