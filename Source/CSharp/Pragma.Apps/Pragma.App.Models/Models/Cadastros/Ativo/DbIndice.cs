using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("VCLUINDICE")]
    public class DbIndice : BaseModel, IModelWithKey<string>
    {
        [Key]
        [StringLength(12), Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        [PgmF4(Show = true)]
        public string Id { get; set; }

        [Column("DS_APELIDO")]
        [PgmColumn(DisplayText = "Apelido")]
        [PgmF4(Show = true)]
        public string Apelido { get; set; }

        [Column("DS_INDICE")]
        [PgmColumn(DisplayText = "Nome")]
        public string Nome { get; set; }

        [Column("NR_CORFUNDO")]
        [PgmColumn(DisplayText = "Cor")]
        public decimal CorFundo { get; set; }

        [Column("TG_INVERTERFRACAO")]
        [PgmColumn(DisplayText = "Inverter?")]
        public decimal Inverter { get; set; }

        /// <summary>
        /// Indica se o índice é relativo à uma moeda
        /// </summary>
        [Column("TG_MOEDA")]
        [PgmColumn(DisplayText = "Moeda?")]
        public decimal TgMoeda { get; set; }

        [Column("CD_MOEDA")]
        public string CdMoeda { get; set; }

    }
}
