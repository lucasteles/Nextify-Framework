using System.Collections.Generic;

namespace Nextify.Excel
{
    public interface IExcelTool
    {
        void ExportFromList<TView>(IList<TView> itens, string local);
    }
}