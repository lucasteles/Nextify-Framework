using Pragma.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUXMLCOTAS")]
    public class DbXmlCotas : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        public int Id { get; set; }

        [Column("FK_CLUBE")]
        public decimal? FkInvestimento { get; set; }

        [Column("DT_CARTEIRA")]
        public DateTime DtPosciao { get; set; }

        public Nullable<decimal> CNPJ { get; set; }
        public string ISIN { get; set; }
        public Nullable<decimal> CNPJFUNDO { get; set; }
        public Nullable<decimal> QTDISPONIVEL { get; set; }
        public Nullable<decimal> QTGARANTIA { get; set; }
        public Nullable<decimal> PUPOSICAO { get; set; }
        public Nullable<decimal> TRIBUTOS { get; set; }
        public string NIVELRSC { get; set; }

    }
}
