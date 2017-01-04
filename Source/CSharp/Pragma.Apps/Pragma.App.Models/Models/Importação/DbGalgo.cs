using Pragma.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUGALGOIMP")]
    public class DbGalgo : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        public int Id { get; set; }

        [Column("DT_IMPORTACAO")]
        [PgmColumn(DisplayText = "Dt. Importação")]
        public DateTime? DtImportacao { get; set; }

        [Column("DS_FUNDO")]
        [PgmColumn(DisplayText = "Nome do Fundo")]
        public string NmFundo { get; set; }

        [Column("DT_CONSULTA")]
        [PgmColumn(DisplayText = "Dt. Consulta")]
        public DateTime? DtConsulta { get; set; }

        [Column("DT_FUNDO")]
        [PgmColumn(DisplayText = "Dt. Fundo")]
        public DateTime? DtFundo { get; set; }

        [Column("CD_STIFUNDO")]
        [PgmColumn(DisplayText = "Cód Sti. do Fundo")]
        public int StiFundo { get; set; }

        [Column("DS_FUNDORAZAO")]
        [PgmColumn(DisplayText = "Razão do Fundo")]
        public string FundoRazao { get; set; }

        [Column("DS_NMADMINISTRATOR")]
        [PgmColumn(DisplayText = "Administrator")]
        public string NmAdministrator { get; set; }

        [Column("VL_COTA")]
        [PgmColumn(DisplayText = "Vl. Cota")]
        public decimal VlCota { get; set; }

        [Column("CD_VALIDACAO")]
        [PgmColumn(DisplayText = "Cód. Validação")]
        public string CodValidacao { get; set; }

        [Column("TG_OFICIAL")]
        [PgmColumn(DisplayText = "Oficial")]
        public decimal Oficial { get; set; }

        [Column("TG_CLASSESUSP")]
        [PgmColumn(DisplayText = "Classes USP")]
        public int ClassesUSP { get; set; }

        [Column("DS_OBS")]
        [PgmColumn(DisplayText = "Observação")]
        public string Observacao { get; set; }

        [Column("VL_PATRIMONIO")]
        [PgmColumn(DisplayText = "Vl. Patrimonio")]
        public decimal VlPatrimonio { get; set; }

        /* TODO : Map this 
            oModelBuilder.Entity<DbGalgo>().Property(i => i.VlCota).HasPrecision(20, 12);
            oModelBuilder.Entity<DbGalgo>().Property(i => i.VlPatrimonio).HasPrecision(20, 5);
        */
    }
}
