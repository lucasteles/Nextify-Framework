
using Pragma.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    /// <summary>
    /// Esta classe armazena o cadastro de cotas oficiais de fundos de cota mensal com delays significativos, destinada principalmente para Hedge Funds Offshore.
    /// </summary>
    [Table("TCLUCONFERENCIACOTAOFICIAL")]
    public class DbCotaOficial : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        public int Id { get; set; }

        [Column("DT_POSICAO")]
        public DateTime DtPosicao { get; set; }

        [Column("FK_ATIVO")]
        public string FkAtivo { get; set; }
        [ForeignKey(nameof(FkAtivo))]
        public virtual DbInvestAtivo Ativo { get; set; }

        [Column("VL_COTA")]
        public decimal VlCotacao { get; set; }

        [Column("DT_DIVULGACAO")]
        public DateTime DtDivulgacao { get; set; }

        public virtual ICollection<DbCotaOficialDivulgacao> ListCotaoficialDivulgacao { get; set; }

        public virtual string Descricao
        {
            get
            {
                return Id == 0 ? "" : FkAtivo + " - " + DtDivulgacao.ToString("dd/MM/yyyy");
            }
        }

        /* TODO : Map this
            oModelBuilder.Entity<DbCotaOficial>().Property(i => i.VlCotacao).HasPrecision(18, 8);

        */
    }
}
