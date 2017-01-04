
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Pragma.Core;

namespace Pragma.App.Model
{
    [Table("TCLUPAGREC")]
    public class DbPagRec : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmF4(Show = true)]
        public int Id { get; set; }

        [Column("FK_DESCLANCAMENTO")]
        [PgmF4(Show = true)]
        public int FkDescLancamento { get; set; }
        [ForeignKey(nameof(FkDescLancamento))]
        public virtual DbPagRecDescricao PagRecDescricao { get; set; }

        [Column("FK_CLUBE")]
        public decimal FkInvestimento { get; set; }
        [ForeignKey(nameof(FkInvestimento))]
        public virtual DbInvestimento Investimento { get; set; }

        [Column("DT_CARTEIRA")]
        public DateTime DtPosicao { get; set; }

        [Column("DT_VENCIMENTO")]
        public DateTime DtVencimento { get; set; }

        [Column("VL_PAGREC")]
        public decimal VlProvisao { get; set; }

        /// <summary>
        /// Ajusta o sinal (positivo/negativo) do VlProvisao de acordo com o TgCd
        /// </summary>
        public virtual decimal VlProvisaoSigned
        {
            get { return Math.Abs(VlProvisao) * (TgCd == "C" ? 1 : -1); }

        }

        [Column("TG_CREDEB")]
        public string TgCd { get; set; }

        [Column("TG_PROVISAO")]
        public byte TgProvisao { get; set; }

        [Column("FK_MOEDA")]
        public string FkMoeda { get; set; }

        /// <summary>
        /// Campo virtual utilizado para auxiliar em manipulaçõe se Listas de Posições. Não carrega nenhum valor significativo que não se ja para um contexto local.
        /// </summary>
        public bool Desconsiderar = false;

        //public int PK_ID { get; set; }
        //public Nullable<int> FK_CLUBE { get; set; }
        //public Nullable<int> FK_DESCLANCAMENTO { get; set; }
        //public Nullable<decimal> VL_PAGREC { get; set; }
        //public string TG_CREDEB { get; set; }
        //public Nullable<System.DateTime> DT_CARTEIRA { get; set; }
        //public Nullable<System.DateTime> DT_VENCIMENTO { get; set; }
        //public Nullable<int> FK_OWNER { get; set; }
        //public Nullable<byte> TG_PROVISAO { get; set; }
        //public string DS_OBSLANCAMENTO { get; set; }
        //public string FK_MOEDA { get; set; }
        //public Nullable<decimal> VL_MOVTOMOEDA { get; set; }
        //public Nullable<decimal> TG_PRORATA { get; set; }
        //public Nullable<decimal> TG_INATIVO { get; set; }

    }
}
