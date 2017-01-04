using Pragma.Core;
using System;

namespace Pragma.App.Model
{
    public enum TipoMovimento
    {
        Ativo,
        Passivo,
        Caixa
    }
    public class AbstractMovimento : BaseModel
    {
        public virtual TipoMovimento TipoMovimento { get; set; }
        public virtual DateTime DtMovimentoPosicao { get; set; }
        public virtual decimal VlPreco { get; set; }
        public virtual decimal QtMovimento { get; set; }
        public virtual decimal VlMovimento { get; set; }
        public virtual string Status { get; set; }

    }
}
