using Pragma.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Pragma.App.Model
{
    [Table("TCLUCARTCONSINDICE")]
    public class DbPublicadoIndice : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        public int Id { get; set; }

        [Column("DS_CLUBES")]
        [PgmColumn(DisplayText = "Lista de Investimentos em Texto")]
        public string TextInvestimentos { get; set; }

        [PgmColumn(DisplayText = "Lista de Investimentos")]
        public ICollection<string> ListInvestimentos { get { return TextInvestimentos.Split(',').ToList(); } }

        [PgmColumn(DisplayText = "Grupo de Investimento")]
        public bool IsGrup { get { return ListInvestimentos.Count > 1; } }

        [Column("TG_NIVEL")]
        [PgmColumn(DisplayText = "Nível")]
        public int TgNivel { get; set; }

        [Column("TG_CONSIDERAR")]
        [PgmColumn(DisplayText = "Desconsiderar")]
        public int TgDesconsiderar { get; set; }

        [Column("TG_LCIBRUTA")]
        [PgmColumn(DisplayText = "LCI Bruta")]
        public int TgLciBruta { get; set; }

        [Column("DT_MINIMA")]
        [PgmColumn(DisplayText = "Dt Minima")]
        public DateTime? DtMinima { get; set; }

        [Column("DT_MAXIMA")]
        [PgmColumn(DisplayText = "Dt Maxima")]
        public DateTime? DtMaxima { get; set; }

        [Column("DT_REPUBLICAR")]
        [PgmColumn(DisplayText = "Dt Republicação")]
        public DateTime? DtRepublicar { get; set; }

    }
}
