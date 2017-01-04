
using Pragma.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Pragma.App.Model
{
    [Table("TCLUPORTFOLIO")]
    public class DbPortfolio : BaseModel, IModelWithKey<string>
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód.")]
        [PgmF4(Show = true)]
        public string Id { get; set; }

        [Column("DS_PORTFOLIO")]
        [PgmColumn(DisplayText = "Portfolio")]
        [PgmF4(Show = true)]
        public string DsPortfolio { get; set; }

        [Column("DS_CLUBES")]
        [PgmColumn(DisplayText = "Lista de Investimentos em texto")]
        public string TextInvestimentos { get; set; }

        [PgmColumn(DisplayText = "Lista de Investimentos")]
        public ICollection<string> ListInvestimentos { get { return TextInvestimentos.Split(',').ToList(); } }

    }
}