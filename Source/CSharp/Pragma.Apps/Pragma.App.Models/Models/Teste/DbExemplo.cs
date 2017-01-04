using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace Pragma.App.Model
{
    [Table("TCLUEXEMPLO")]
    public class DbExemplo : BaseModel, IModelWithKey<string>
    {
        public DbExemplo()
        {
            Owner = 48;
        }

        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }

        [Column("DS_EXEMPLO")]
        [PgmColumn(DisplayText = "Desc. Exemplo")]
        public string Desc { get; set; }

        [Column("VL_EXEMPLO")]
        [PgmColumn(DisplayText = "Vl. Exemplo")]
        public decimal Valor { get; set; }

        [Column("FK_TESTE")]
        [PgmColumn(DisplayText = "Cód Teste")]
        public int FkTeste { get; set; }
        [ForeignKey(nameof(FkTeste))]
        [XmlIgnore]
        public virtual DbTeste Teste { get; set; }

    }
}
