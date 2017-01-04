
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Pragma.Core;

namespace Pragma.App.Model
{
    [Table("TCLUCONCILIACAOJUSTIFICATIVA")]
    public class DbConciliacaoJustificativa : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        public int Id { get; set; }

        [Column("FK_CONFERENCIA")]
        public int FkConferencia { get; set; }
        [ForeignKey(nameof(FkConferencia))]
        public virtual DbConferencia Conferencia { get; set; }

        [Column("FK_INVESTIMENTO")]
        public decimal? FkInvestimento { get; set; }
        [ForeignKey(nameof(FkInvestimento))]
        public virtual DbInvestimento Investimento { get; set; }

        [Column("FK_ATIVO")]
        public string FkAtivo { get; set; }
        [ForeignKey(nameof(FkAtivo))]
        public virtual DbInvestAtivo Ativo { get; set; }

        [Column("CD_ORIGEM")]
        public string Codigo { get; set; }

        [Column("DT_POSICAO")]
        public DateTime DtPosicao { get; set; }

        [Column("DS_JUSTIFICATIVA")]
        public string DsJustificativa { get; set; }

        [Column("FK_MOTIVO")]
        public int FkMotivo { get; set; }
        [ForeignKey(nameof(FkMotivo))]
        public virtual DbConciliacaoMotivo Motivo { get; set; }

    }
}
