using Pragma.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUGALGOLOG")]
    public class DbGalgoLog : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        public int Id { get; set; }

        [Column("DT_INICIO")]
        [PgmColumn(DisplayText = "Dt. Inicio")]
        public DateTime? DtInicio { get; set; }

        [Column("DT_FINAL")]
        [PgmColumn(DisplayText = "Dt. Final")]
        public DateTime? DtFinal { get; set; }

        [Column("TG_ACAO")]
        [PgmColumn(DisplayText = "Ação")]
        public string Acao { get; set; }

        [Column("NR_REG")]
        [PgmColumn(DisplayText = "Registros")]
        public int NrReg { get; set; }

        /* TODO: Map this 
            oModelBuilder.Entity<DbGalgo>().Property(i => i.VlCota).HasPrecision(20, 12);
            oModelBuilder.Entity<DbGalgo>().Property(i => i.VlPatrimonio).HasPrecision(20, 5);
        
            */
    }
}
