using Pragma.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUXMLHEADER")]
    public class DbXmlHeader : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        public int Id { get; set; }

        [Column("FK_CLUBE")]
        public decimal FkInvestimento { get; set; }

        [Column("DT_CARTEIRA")]
        public DateTime DtPosciao { get; set; }

        public string ISIN { get; set; }
        public Nullable<decimal> CNPJ { get; set; }
        public string NOME { get; set; }
        public string DTPOSICAO { get; set; }
        public string NOMEADM { get; set; }
        public string CNPJADM { get; set; }
        public string NOMEGESTOR { get; set; }
        public Nullable<decimal> CNPJGESTOR { get; set; }
        public string NOMECUSTODIANTE { get; set; }
        public Nullable<decimal> CNPJCUSTODIANTE { get; set; }
        public Nullable<decimal> VALORCOTA { get; set; }
        public Nullable<decimal> QUANTIDADE { get; set; }
        public Nullable<decimal> PATLIQ { get; set; }
        public Nullable<decimal> VALORATIVOS { get; set; }
        public Nullable<decimal> VALORRECEBER { get; set; }
        public Nullable<decimal> VALORPAGAR { get; set; }
        public Nullable<decimal> VLCOTASEMITIR { get; set; }
        public Nullable<decimal> VLCOTASRESGATAR { get; set; }
        public string CODANBID { get; set; }
        public Nullable<decimal> TIPOFUNDO { get; set; }
        public string NIVELRSC { get; set; }

    }
}
