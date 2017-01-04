
using Pragma.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUFERIADOGENERICO")]
    // [PgmDataBase(Connection = "HomologIntraConnection")]
    public class DbFeriadoGenerico : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        public int Id { get; set; }

        [Column("FK_PAIS")]
        public string FkPais { get; set; }
        [ForeignKey(nameof(FkPais))]
        public virtual DbPaisNovo Pais { get; set; }

        [Column("FK_SUBDIVISAO")]
        public int? FkSubdivisao { get; set; }
        [ForeignKey(nameof(FkSubdivisao))]
        public virtual DbSubdivisao Subdivisao { get; set; }

        [Column("FK_CIDADE")]
        public int? FkCidade { get; set; }
        [ForeignKey(nameof(FkCidade))]
        public virtual DbCidadeNovo Cidade { get; set; }

        [Column("DS_NOME")]
        public string Nome { get; set; }

        [Column("DT_FERIADO")]
        public DateTime Data { get; set; }

        [Column("CD_TIPO")]
        public TipoFeriado Tipo { get; set; }

    }

    public enum TipoFeriado
    {
        Nacional = 1,
        Estadual = 2,
        Municipal = 3
    }
}