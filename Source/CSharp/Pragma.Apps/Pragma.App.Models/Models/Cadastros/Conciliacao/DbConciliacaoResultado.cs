using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Pragma.Core;

namespace Pragma.App.Model
{
    [Table("TCLUCONCILIACAORESULTADO")]
    public class DbConciliacaoResultado : BaseModel, IModelWithKey
    {
        public DbConciliacaoResultado() { }

        public DbConciliacaoResultado(DbConferencia conferencia, DateTime dtPosicao, DbInvestimento investimento = null,
                                    DbInvestAtivo ativo = null, string codigo = null, DbConciliacaoErro erro = null, string mensagem = null, string infoAdicional = null)
        {
            FkConferencia = conferencia.Id;
            Conferencia = conferencia;
            DtPosicao = dtPosicao;
            FkInvestimento = investimento?.Id;
            Investimento = investimento;
            FkAtivo = ativo?.Id;
            Ativo = ativo;
            Codigo = codigo;
            FkErro = erro?.Id;
            Erro = erro;
            Status = erro != null ? StatusConciliacao.Errado : StatusConciliacao.Ok;
            Mensagem = mensagem;
            InformacaoAdicional = infoAdicional;
        }

        [Key]
        [Column("PK_ID")]
        public int Id { get; set; }

        [Column("FK_CONCILIACAO")]
        public int FkConciliacao { get; set; }

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

        [Column("NR_STATUS")]
        public StatusConciliacao Status { get; set; }

        [Column("DS_MENSAGEM")]
        public string Mensagem { get; set; }

        [Column("FK_ERRO")]
        public int? FkErro { get; set; }
        [ForeignKey(nameof(FkErro))]
        public virtual DbConciliacaoErro Erro { get; set; }

        [Column("DS_INFORMACAOADICIONAL")]
        public string InformacaoAdicional { get; set; }

    }

    /// <summary>
    /// Status do Resultado de uma conferência
    /// </summary>
    public enum StatusConciliacao
    {
        Ok = 1,
        Errado = 2,
        Justificado = 3
    }
}
