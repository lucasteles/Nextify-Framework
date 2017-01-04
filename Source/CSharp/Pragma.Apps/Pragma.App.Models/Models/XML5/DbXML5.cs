using Pragma.Core;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("XMLTest")]
    // // [PgmDataBaseAttribute(Connection = "HomologIntraConnection")]
    public class DbXML5 : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        public int Id { get; set; }

        [Column("CNPJ")]
        public string Cnpj { get; set; }
        [Column("DT_POSICAO")]
        public DateTime DtPosicao { get; set; }
        [Column("DH_GERACAO")]
        public DateTime DhGeracao { get; set; }
        [Column("FUNDO")]
        public string Fundo { get; set; }
        [Column("PAGINA")]
        public int Pagina { get; set; }
        [Column("ULTIMA_PAGINA")]
        public bool UltimaPagina { get; set; }

        [Column("XML")]
        public string Xml { get; set; }

        [Column("INVESTIMENTO_Id")]
        public decimal Investimento { get; set; }

        [Column("ARQUIVO")]
        public string NomeDoArquivo { get; set; }

        [NotMapped]
        public string Status { get; set; }
        [NotMapped]
        public bool Adicionar { get; set; }
        [NotMapped]
        public string InvestimentoTxt { get; set; }

    }
}
