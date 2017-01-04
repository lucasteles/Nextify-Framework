using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using PGM.Xml.Tools.Anbima4;
using Pragma.Forms.Controllers.Abstraction;
using Pragma.Forms.Controls;
using Pragma.Core;

namespace Pragma.App.Forms.Controllers.Grids
{
    public interface IXMLFilesGridController : IGridController<ComparadorAnbima4Parameter>
    {
        void SetComparador(ComparadorAnbima4 comparador);
    }
    public class XMLFilesGridController : AbstractGridController<ComparadorAnbima4Parameter>, IXMLFilesGridController
    {
        ComparadorAnbima4 Comparador { get; set; }
        public XMLFilesGridController()
        {
            AddMenu("Abrir Raiz", OpenRaiz);
            AddMenu("Abrir Old", OpenOld);
        }
        public override void SetPredicate(Expression<Func<ComparadorAnbima4Parameter, bool>> predicate)
        {
        }

        protected override Task<IEnumerable<ComparadorAnbima4Parameter>> GetForGridAsync()
        {
            var oHeader = new List<PgmColumn>
            {
                new PgmColumn{PropertyName = "Raizname"  ,DisplayText = "Xml Raiz", ColumnMinSize=450   },
                new PgmColumn{PropertyName = "Oldname"  ,DisplayText = "Xml Old", ColumnMinSize=450     },
                new PgmColumn{PropertyName = "Tagname"   ,DisplayText = "Tag com Erro"                  },
                new PgmColumn{PropertyName = "NumError"   ,DisplayText = "Num. Erro"                  }
            };

            //SetHeader(oHeader);
            return Comparador.GetListAsync();
        }

        public void SetComparador(ComparadorAnbima4 comparador)
        {
            Comparador = comparador;
        }
        public void OpenRaiz()
        {
            ComparadorAnbima4.OpenRaiz(GetSelected());
        }
        public void OpenOld()
        {
            ComparadorAnbima4.OpenOld(GetSelected());
        }
    }
}
