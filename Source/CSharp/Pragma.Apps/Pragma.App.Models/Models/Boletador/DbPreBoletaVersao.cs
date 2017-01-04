using Pragma.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUPREBOLETAVERSAO")]
    public class DbPreBoletaVersao : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        public int Id { get; set; }

        [Column("FK_PREBOLETA")]
        [PgmColumn(DisplayText = "Cód. Preboleta")]
        public int FkPreboleta { get; set; }
        //[ForeignKey(nameof(FkPreboleta))]
        //public virtual DbPreBoleta PreBoleta { get; set; }

        [Column("FK_CLUBE")]
        [PgmColumn(DisplayText = "Cód Investimento")]
        public decimal FkInvestimento { get; set; }
        [ForeignKey(nameof(FkInvestimento))]
        public virtual DbInvestimento Investimento { get; set; }

        [Column("FK_ATIVO")]
        public string FkAtivo { get; set; }
        [ForeignKey(nameof(FkAtivo))]
        public virtual DbInvestAtivo Ativo { get; set; }

        [Column("FK_STATUS")]
        [PgmColumn(DisplayText = "Cód. Status")]
        public int FkStatus { get; set; }
        [ForeignKey(nameof(FkStatus))]
        public virtual DbStatusPreBoleta StatusPrebol { get; set; }

        [Column("DT_MOVTO")]
        [PgmColumn(DisplayText = "Dt. Movimento")]
        public DateTime DtMovimento { get; set; }

        [Column("VL_LIQUIDO")]
        [PgmColumn(DisplayText = "Vl. Liquido")]
        public decimal VlLiquido { get; set; }

        [Column("TG_MOVTO")]
        [PgmColumn(DisplayText = "Tp. Movto")]
        public string TgMovto { get; set; }

    }
}
