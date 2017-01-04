using System.Collections.Generic;

namespace Pragma.Excel
{
    public interface IExcelTool
    {
        void ExportFromList<TView>(IList<TView> itens, string local);
    }
}