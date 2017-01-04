using Pragma.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUCARTCONSPERFIL")]
    public class DbPublicadoPerfil : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        public int Id { get; set; }

        [Column("DS_CLUBES")]
        [PgmColumn(DisplayText = "Lista de Investimentos em Texto")]
        public string TextInvestimentos { get; set; }

        [PgmColumn(DisplayText = "Lista de Investimentos")]
        public int FkInvestimentos { get { return Convert.ToInt16(TextInvestimentos); } }

        [Column("TG_NIVEL")]
        public decimal NivelAbertura { get; set; }

        [Column("TG_DESCONSIDERAR")]
        public decimal Desconsiderar { get; set; }

        [Column("TG_LCIBRUTA")]
        public decimal LciBruta { get; set; }

        [Column("NR_DECIMAIS")]
        public decimal NrDecimais { get; set; }

    }
}
