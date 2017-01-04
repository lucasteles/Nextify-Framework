using Pragma.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("CADASTRO_MENUS")]
    public class DbMenuSistema : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód.")]
        public int Id { get; set; }

        [Column("NOME")]
        [PgmColumn(DisplayText = nameof(Nome))]
        public string Nome { get; set; }

        [Column("FK_MENU")]
        [PgmColumn(DisplayText = "Menu Pai", DataOrderPriority = 2)]
        public int FkMenu { get; set; }
        [ForeignKey(nameof(FkMenu))]
        public virtual DbMenuSistema MenuPai { get; set; }

        public virtual List<DbMenuSistema> MenusFilhos { get; set; } = new List<DbMenuSistema>();

        [Column("ORDEM")]
        [PgmColumn(DisplayText = nameof(Ordem), DataOrderPriority = 1)]
        public int Ordem { get; set; }

        [Column("CLASSE")]
        [PgmColumn(DisplayText = nameof(Classe))]
        public string Classe { get; set; }

        [Column("NAMESPACE")]
        [PgmColumn(DisplayText = nameof(Namespace))]
        public string Namespace { get; set; }

        [Column("CLASSE_ICONE")]
        [PgmColumn(DisplayText = "Classe do Icone")]
        public string ClasseDoIcone { get; set; }

        [Column("ICONE")]
        [PgmColumn(DisplayText = nameof(Icone))]
        public string Icone { get; set; }
    }
}
