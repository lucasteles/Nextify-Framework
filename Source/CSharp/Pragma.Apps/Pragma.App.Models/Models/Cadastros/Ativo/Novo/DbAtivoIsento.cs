using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    /// <summary>
    /// Corresponde a tabela auxiliar de cadastro de Ativos Isentos, antigamente comhecida como DbAtivoLci
    /// </summary>
    [Table("TCLUATIVOLCI")]
    public class DbAtivoIsento : BaseModel, IModelWithKey<string>
    {
        [Key]
        [Column("PK_ID")]
        public string Id { get; set; }

        [Column("DS_LCI")]
        public string DsLci { get; set; }

        [Column("FK_ATIVO")]
        public string FkAtivo { get; set; }

        /// <summary>
        /// Indice Base para a geração de cotações, no caso da flag TgGerarCotacao = 1
        /// </summary>
        [Column("FK_INDICE")]
        public string FkIndice { get; set; }

        /// <summary>
        /// Indice Base para a geração de cotações, no caso da flag TgGerarCotacao = 1
        /// </summary>
        [ForeignKey(nameof(FkIndice))]
        public virtual DbIndice Indice { get; set; }

        [Column("VL_PORINDICE")]
        public decimal VlPorindice { get; set; }

        [Column("VL_FATORBRUTO")]
        public decimal VlFatorbruto { get; set; }

        [Column("DT_VENCIMENTO")]
        public System.DateTime? DtVencimento { get; set; }

        [Column("DT_BLOQUEIO")]
        public System.DateTime? DtBloqueio { get; set; }

        [Column("TG_FORCELIQUIDEZ")]
        public decimal? TgForceliquidez { get; set; }

        [Column("NR_LIQUIDEZ")]
        public int? NrLiquidez { get; set; }

        [Column("FK_EMISSOR")]
        public int? FkEmissor { get; set; }

        [Column("FK_INSTITUICAO")]
        public int? FkInstituicao { get; set; }

    }
}
