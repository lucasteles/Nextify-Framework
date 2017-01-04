
using Pragma.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    //// [PgmDataBase(Connection = "HomologIntraConnection")]
    [Table("TCLUCONFERENCIAAJUSTE")]
    public class DbAjuste : BaseModel, IModelWithKey
    {
        public enum TipoAjuste
        {
            /// <summary>
            /// (0) Não idêntificado
            /// </summary>
            NaoIdentificado = 0,
            /// <summary>
            /// Regra de desconsiderar um atigvo de uma Conferencia
            /// </summary>
            Desconsiderar = 1,
            /// <summary>
            /// Regra de DePara para uma conferencia
            /// </summary>
            DeParaAtivo = 2,
        }

        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód.")]
        [PgmF4(Show = true)]
        public int Id { get; set; }

        [Column("FK_TIPOAJUSTE")]
        [PgmF4(Show = true)]
        public decimal FkTipoAjuste { get; set; }

        [PgmColumn(DisplayText = "Tipo Ajuste")]
        public virtual string DsTipoAjuste
        {
            get
            {
                return Enum.GetName(typeof(TipoAjuste), (TipoAjuste)FkTipoAjuste);
            }
        }

        [Column("FK_CLUBEORIGINAL")]
        [PgmColumn(DisplayText = "Cód Investimento Original")]
        public decimal FkInvestimentoOriginal { get; set; }
        [ForeignKey(nameof(FkInvestimentoOriginal))]
        public virtual DbInvestimento InvestimentoOriginal { get; set; }

        [Column("FK_ATIVOORIGINAL")]
        [PgmColumn(DisplayText = "Cód Ativo Original")]
        public string FkAtivoOriginal { get; set; }
        [ForeignKey(nameof(FkAtivoOriginal))]
        public virtual DbInvestAtivo AtivoOriginal { get; set; }

        [Column("FK_ATIVODESTINO")]
        [PgmColumn(DisplayText = "Cód Ativo Destino")]
        public string FkAtivoDestino { get; set; }
        [ForeignKey(nameof(FkAtivoDestino))]
        public virtual DbInvestAtivo AtivoDestino { get; set; }

    }
}
