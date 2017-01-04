
using Pragma.Core;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUPPTPAGINA")]
    public class DbPptPagina : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        [PgmF4(Show = true)]
        public int Id { get; set; }

        [Column("DS_NOME")]
        [PgmColumn(DisplayText = "Nome da pagina")]
        [PgmF4(Show = true)]
        public string Nome { get; set; }

        [Column("TG_REGIAO")]
        [PgmColumn(DisplayText = "Região")]
        public decimal Regiao { get; set; }

        [Column("FK_MOEDAPRINCIPAL")]
        [PgmColumn(DisplayText = "Moeda Principal")]
        public string FkMoedaPrincipal { get; set; }
        [ForeignKey(nameof(FkMoedaPrincipal))]
        public virtual DbIndice MoedaPrincipal { get; set; }

        [Column("FK_MOEDASECUNDARIA")]
        [PgmColumn(DisplayText = "Moeda Secundária")]
        public string FkMoedaSecundaria { get; set; }
        [ForeignKey(nameof(FkMoedaSecundaria))]
        public virtual DbIndice MoedaSecundaria { get; set; }

        [Column("FK_ROTINA")]
        [PgmColumn(DisplayText = "Cód Rotina")]
        public int? FkRotina { get; set; }
        [ForeignKey(nameof(FkRotina))]
        public virtual DbPptRotina PptRotina { get; set; }

        [Column("NR_DECIMAIS")]
        [PgmColumn(DisplayText = "Nr.Decimais")]
        public decimal NrDecimais { get; set; }

        [Column("TG_CALCANUALIADO")]
        [PgmColumn(DisplayText = "Calculo Anualizado")]
        public bool TgCalcAnualiado { get; set; }

        [Column("TG_TIPOGERAR")]
        [PgmColumn(DisplayText = "Tipo Geração")]
        public decimal TgTipoGerar { get; set; }

    }
}
