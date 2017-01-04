using Pragma.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUMOVIMENTOPASSIVO")]
    public class DbMovimentoPassivo : AbstractMovimento, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        [PgmF4(Show = true)]
        public int Id { get; set; }

        [Column("FK_MOVIMENTOPASSIVOITEM")]
        [PgmColumn(DisplayText = "Cód Movimento Atual")]
        public int FkMovimentoPassivoItem { get; set; }
        public virtual DbMovimentacaoPassivoItem MovimentoPassivoItem { get; set; }

        [Column("FK_MOVIMENTOEVENTO")]
        [PgmColumn(DisplayText = "Cód Evento")]
        public int FkMovimentoEvento { get; set; }
        [ForeignKey(nameof(FkMovimentoEvento))]
        public virtual DbMovimentacaoEvento MovimentoEvento { get; set; }

        public virtual ICollection<DbMovimentacaoPassivoItem> ListMovimentoPassivoItem { get; set; }

    }
}