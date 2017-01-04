
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Pragma.Core;

namespace Pragma.App.Model
{
    /// <summary>
    /// Esta classe armazena o cadastro de cotas oficiais de fundos de cota mensal com delays significativos, destinada principalmente para Hedge Funds Offshore.
    /// </summary>
    [Table("TCLUCONFERENCIACOTAOFICIALDIVULGACAO")]
    public class DbCotaOficialDivulgacao : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        public int Id { get; set; }

        [Column("FK_COTAOFICIAL")]
        public int FkCotaOficial { get; set; }
        [ForeignKey(nameof(FkCotaOficial))]
        public virtual DbCotaOficial CotaOficial { get; set; }

        [Column("DT_DIVULGACAO")]
        public DateTime DtDivulgacao { get; set; }

        [Column("FK_INSTITUICAO")]
        public int FkInstituicao { get; set; }
        [ForeignKey(nameof(FkInstituicao))]
        public virtual DbInstituicao Instituicao { get; set; }

    }
}
