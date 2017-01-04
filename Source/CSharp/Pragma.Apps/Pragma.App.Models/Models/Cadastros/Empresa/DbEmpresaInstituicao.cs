using Pragma.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUEMPRESACONTATO")]
    public class DbEmpresaInstituicao : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        [PgmF4(Show = true)]
        public int Id { get; set; }

        [Column("FK_EMPRESA")]
        [PgmColumn(DisplayText = "Cód Empresa")]
        public int FkEmpresa { get; set; }
        [ForeignKey(nameof(FkEmpresa))]
        public virtual DbEmpresa Empresa { get; set; }

        [Column("FK_EMPRESATIPO")]
        [PgmColumn(DisplayText = "Cód Tipo Empresa")]
        public int FkEmpresaTipo { get; set; }
        [ForeignKey(nameof(FkEmpresaTipo))]
        public virtual DbEmpresaTipo EmpresaTipo { get; set; }

        [Column("DS_NOME")]
        [PgmColumn(DisplayText = "Contato")]
        [PgmF4(Show = true)]
        public string Nome { get; set; }

        [Column("CD_CONTATO")]
        [PgmColumn(DisplayText = "Código")]
        [PgmF4(Show = true)]
        public string Codigo { get; set; }

        [Column("DS_EMAILS")]
        [PgmColumn(DisplayText = "Emails")]
        public string Emails { get; set; }

        [Column("NR_TELEFONE")]
        [PgmColumn(DisplayText = "Telefone")]
        public decimal Telefone { get; set; }

        [Column("NR_FAX")]
        [PgmColumn(DisplayText = "Fax")]
        public decimal Fax { get; set; }

    }
}
