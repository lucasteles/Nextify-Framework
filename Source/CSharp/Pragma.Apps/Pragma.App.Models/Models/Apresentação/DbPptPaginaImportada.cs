using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using System;

using Pragma.Core;

namespace Pragma.App.Model
{
    [Table("TCLUPPTPAGINAIMPORTADA")]
    public class DbPptPaginaImportada : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Id.")]
        public int Id { get; set; }

        [Column("FK_PPTPAGINA")]
        [PgmColumn(DisplayText = "Cód Pagina")]
        public int FkPptPagina { get; set; }

        [ForeignKey(nameof(FkPptPagina))]
        public virtual DbPptPagina PptPagina { get; set; }

        [Column("DT_REFERENCIA")]
        [PgmColumn(DisplayText = "Dt. Referência")]
        public DateTime? DtReferencia { get; set; }

        [Column("DS_NOME")]
        [PgmColumn(DisplayText = "Nome")]
        public string Nome { get; set; }

        [Column("DS_CONTEUDO")]
        [PgmColumn(DisplayText = "Conteudo")]
        public byte[] Conteudo { get; set; }

    }
}
