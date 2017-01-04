using Pragma.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pragma.App.Model
{
    [Table("TCLUMOVIMENTOATIVO")]
    public class DbMovimentoAtivo : AbstractMovimento, IModelWithKey
    {
        public virtual new TipoMovimento TipoMovimento { get { return TipoMovimento.Ativo; } }
        public virtual new DateTime DtMovimentoPosicao { get { return MovimentoAtivoItem.DtMovimento; } }
        public virtual new decimal VlPreco { get { return MovimentoAtivoItem.VlPreco; } }
        public virtual new decimal QtMovimento { get { return MovimentoAtivoItem.QtMovimento; } }
        public virtual new decimal VlMovimento { get { return MovimentoAtivoItem.VlMovimento; } }
        public virtual new string Status { get { return MovimentoAtivoItem.MovimentoStatus.Nome; } }

        [Key]
        [Column("PK_ID")]
        [PgmColumn(DisplayText = "Cód")]
        [PgmF4(Show = true)]
        public int Id { get; set; }

        [Column("FK_MOVIMENTOATIVOITEM")]
        [PgmColumn(DisplayText = "Cód Movimento Atual")]
        public int FkMovimentoAtivoItem { get; set; }
        public virtual DbMovimentoAtivoItem MovimentoAtivoItem { get; set; }

        [Column("FK_MOVIMENTOEVENTO")]
        [PgmColumn(DisplayText = "Cód Evento")]
        public int FkMovimento { get; set; }
        [ForeignKey(nameof(FkMovimento))]
        public virtual DbMovimentacaoEvento Movimento { get; set; }

        public virtual ICollection<DbMovimentoAtivoItem> ListMovimentoAtivoItem { get; set; }

        /*TODO: Map this
            new DbMovimentoAtivoItem().OnCreating(oModelBuilder);
        */
    }
}