using Pragma.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUMOVIMENTOATIVOITEM")]
    public class DbMovimentoAtivoItem : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        [PgmF4(Show = true)]
        public int Id { get; set; }

        [Column("FK_TIPOATIVO")]
        [PgmColumn(DisplayText = "Cód Tipo Ativo")]
        public int FkAtivoTipo { get; set; }
        [ForeignKey(nameof(FkAtivoTipo))]
        public virtual DbAtivoTipo AtivoTipo { get; set; }

        [Column("FK_MOVIMENTOATIVO")]
        [PgmColumn(DisplayText = "Cód Movimento Atual")]
        public int FkMovimentoAtivo { get; set; }

        public virtual DbMovimentoAtivo MovimentacaoAtivo { get; set; }
        public virtual ICollection<DbMovimentoAtivo> ListMovimentoAtivo { get; set; }

        [Column("FK_MOVIMENTOSTATUS")]
        [PgmColumn(DisplayText = "Cód Status")]
        public int FkMovimentoStatus { get; set; }
        [ForeignKey(nameof(FkMovimentoStatus))]
        public virtual DbMovimentacaoStatus MovimentoStatus { get; set; }

        [Column("FK_CLUBE")]
        [PgmColumn(DisplayText = nameof(Investimento))]
        public decimal FkInvestimento { get; set; }
        [ForeignKey(nameof(FkInvestimento))]
        public virtual DbInvestimento Investimento { get; set; }

        [Column("DT_MOVTO")]
        [PgmColumn(DisplayText = "Dt. Movimento")]
        public DateTime DtMovimento { get; set; }

        [Column("DT_COTIZACAO")]
        [PgmColumn(DisplayText = "Dt. Cotização")]
        public DateTime DtCotizacao { get; set; }

        [Column("DT_LIQUIDACAO")]
        [PgmColumn(DisplayText = "Dt. Liquidação")]
        public DateTime DtLiquidacao { get; set; }

        [Column("FK_ATIVO")]
        [PgmColumn(DisplayText = nameof(Ativo))]
        public string FkAtivo { get; set; }
        [ForeignKey(nameof(FkAtivo))]
        public virtual DbAtivo Ativo { get; set; }

        [Column("TP_COMPRAVENDA")]
        [PgmColumn(DisplayText = "Compra/Venda")]
        public decimal TpCompraVenda { get; set; }

        [Column("TP_MOVIMENTO")]
        [PgmColumn(DisplayText = "Tipo Movimento")]
        public decimal TpMovimento { get; set; }

        [Column("FK_MOEDA")]
        [PgmColumn(DisplayText = "Cód Moeda")]
        public string FkMoeda { get; set; }
        [ForeignKey(nameof(FkMoeda))]
        public virtual DbIndice Indice { get; set; }

        [Column("FK_ESTRATEGIA")]
        [PgmColumn(DisplayText = "Cód Estratégia")]
        public int FkEstrategia { get; set; }
        [ForeignKey(nameof(FkEstrategia))]
        public virtual DbEstrategia Estrategia { get; set; }

        [Column("FK_CLASSIFICACAO")]
        [PgmColumn(DisplayText = "Cód Classificação")]
        public int FkClassificacao { get; set; }
        [ForeignKey(nameof(FkClassificacao))]
        public virtual DbAtivoClassificacao Classificacao { get; set; }

        [Column("QT_MOVIMENTO")]
        [PgmColumn(DisplayText = "Qt. Movimento")]
        public decimal QtMovimento { get; set; }

        [Column("VL_PRECO")]
        [PgmColumn(DisplayText = "Vl. Preço")]
        public decimal VlPreco { get; set; }

        [Column("VL_MOVIMENTO")]
        [PgmColumn(DisplayText = "Vl. Movimento")]
        public decimal VlMovimento { get; set; }

        [Column("TG_RESGATETOTAL")]
        [PgmColumn(DisplayText = "Resgate Total?")]
        public bool TgResgateTotal { get; set; }

        [Column("TG_COTAMOVIMENTO")]
        [PgmColumn(DisplayText = "Usar Cota do Movimento?")]
        public bool tgCotaMovimento { get; set; }

        [Column("FK_LIQUIDACAOMODO")]
        [PgmColumn(DisplayText = "Modo Liquidação")]
        public string FkLiquidacaoModo { get; set; }
        [ForeignKey(nameof(FkLiquidacaoModo))]
        public virtual DbLiquidacaoModo LiquidacaoModo { get; set; }

        [Column("FK_LIQUIDACAOTIPO")]
        [PgmColumn(DisplayText = "Tipo Liquidação")]
        public string FkLiquidacaoTipo { get; set; }
        [ForeignKey(nameof(FkLiquidacaoTipo))]
        public virtual DbLiquidacaoTipo LiquidacaoTipo { get; set; }

        [Column("FK_CONTANEW")]
        [PgmColumn(DisplayText = "Conta")]
        public string FkConta { get; set; }
        //[ForeignKey(nameof(FkConta))]
        //public virtual DbConta Conta { get; set; }

        [Column("FK_CUSTODIANTE")]
        [PgmColumn(DisplayText = nameof(Custodiante))]
        public int FkCustodiante { get; set; }
        [ForeignKey(nameof(FkCustodiante))]
        public virtual DbEmpresaInstituicao Custodiante { get; set; }

        [Column("FK_CORRETORA")]
        [PgmColumn(DisplayText = nameof(Corretora))]
        public int FkCorretora { get; set; }
        [ForeignKey(nameof(FkCorretora))]
        public virtual DbEmpresaInstituicao Corretora { get; set; }

        [Column("DT_VENCIMENTO")]
        [PgmColumn(DisplayText = "Dt. Vencimento")]
        public DateTime DtVencimento { get; set; }

        [Column("TG_OPERACAOREGISTRO")]
        [PgmColumn(DisplayText = "Operação com registro?")]
        public bool TgOperacaoRegistro { get; set; }

        [Column("TP_OPCAO")]
        [PgmColumn(DisplayText = "Tipo Opção")]
        public decimal TpOpcao { get; set; }

        [Column("CD_SERIE")]
        [PgmColumn(DisplayText = "Cód. Serie")]
        public string Serie { get; set; }

        [Column("TP_OPERACAO")]
        [PgmColumn(DisplayText = "Tipo Operação")]
        public decimal TpOperacao { get; set; }

        /* TODO: Map this
            oModelBuilder.Entity<DbMovimentoAtivoItem>()
            .HasRequired(e => e.MovimentacaoAtivo)
            .WithMany(e => e.ListMovimentoAtivoItem)
            .HasForeignKey(e => e.FkMovimentoAtivo);

            oModelBuilder.Entity<DbMovimentoAtivo>()
                .HasRequired(e => e.MovimentoAtivoItem)
                .WithMany(e => e.ListMovimentoAtivo)
                .HasForeignKey(e => e.FkMovimentoAtivoItem);
        */
    }
}