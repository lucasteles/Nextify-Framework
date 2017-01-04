using Npoi.Mapper;
using System.Collections.Generic;

namespace Pragma.Excel
{
    public class ExcelTool : IExcelTool
    {
        public void ExportFromList<TView>(IList<TView> itens, string local)
        {
            var mapper = new Mapper();

            mapper.Save(local, itens, "Plan1", overwrite: false);

        }

    }
}
