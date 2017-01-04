using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Pragma.Core;

namespace Pragma.App.Model
{
    [Table("TCLUCONVERSAO")]
    public class DbConversaoMoeda : BaseModel, IModelWithKey
    {
        [Key]
        [Column("PK_ID")]
        public int Id { get; set; }

        [Column("FK_INDICEORIGEM")]
        public string FkIndiceOrigem { get; set; }

        [Column("FK_INDICEDESTINO")]
        public string FkIndiceDestino { get; set; }

        [Column("TG_COTACAOINVERTIDA")]
        public byte TgCotacaoInvertida { get; set; }

        [Column("FK_INDICE")]
        public string FkIndice { get; set; }

        [Column("FK_INSTITUICAO")]
        public int FkInstituicao { get; set; }

    }
}
