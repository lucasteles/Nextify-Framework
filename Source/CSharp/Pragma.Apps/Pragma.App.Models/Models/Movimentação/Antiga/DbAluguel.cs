using Pragma.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{

    [Table("TCLUBTC")]
    public class DbAluguel : BaseModel, IModelWithKey<decimal>
    {
        [Key]
        [Column("PK_ID")]
        public decimal Id { get; set; }

        [Column("FK_CLUBE")]
        public decimal FkInvestimento { get; set; }
        [ForeignKey(nameof(FkInvestimento))]
        public virtual DbInvestimento Investimento { get; set; }

        [Column("FK_ATIVO")]
        public string FkAtivo { get; set; }
        [ForeignKey(nameof(FkAtivo))]
        public virtual DbInvestAtivo Ativo { get; set; }

        /// <summary>
        /// Data inicial do aluguel.
        /// </summary>
        [Column("DT_INICIO")]
        public System.DateTime DtInicio { get; set; }

        /// <summary>
        /// Data efetiva que ocorreu o fim do aluguel (reversão da operação).
        /// </summary>
        [Column("DT_BAIXA")]
        public DateTime? DtReversao { get; set; }

        /// <summary>
        /// Data estimada do vencimento do aluguel. Caso açguma das  contrapartes finalize o empréstimo antes, a data final efetiva do aluguel será indicada pelo campo DtReversao.
        /// </summary>
        [Column("DT_VENCIMENTO")]
        public System.DateTime DtVencimento { get; set; }

        /// <summary>
        /// Cotação inicial do aluguel.
        /// </summary>
        [Column("VL_COTACAOINI")]
        public decimal VlCotacao { get; set; }

        /// <summary>
        /// Valor total do aluguel. VlTotal = VlCotacao * QtLote * QtAluguel
        /// </summary>
        [Column("VL_PRECOINI")]
        public decimal VlTotal { get; set; }

        [Column("QT_LOTE")]
        public decimal QtLote { get; set; }

        /// <summary>
        /// Quantidade total alugada (de lotes).
        /// </summary>
        [Column("QT_BTC")]
        public decimal QtAluguel { get; set; }

        /// <summary>
        /// Percentual de taxa de juros "ao ano" do aluguel. Importante: este campo considera que o valor já é um percentual, ou seja, um valor de "8,15" significa 8,15%.
        /// </summary>
        [Column("VL_TAXA")]
        public decimal VlTaxa { get; set; }

        /// <summary>
        /// Indica qual lado da operação o Investimento possui posição, sendo : D=Doador ; T=Tomador
        /// </summary>
        [Column("TG_LADO")]
        public string TgLadoPosicao { get; set; }

        /// <summary>
        /// Indica qual o tipo de reversão da operação, sendo: R=Reversivel; F=Fixo
        /// </summary>
        [Column("TG_TIPO")]
        public string TgTipoReversao { get; set; }

    }
}
