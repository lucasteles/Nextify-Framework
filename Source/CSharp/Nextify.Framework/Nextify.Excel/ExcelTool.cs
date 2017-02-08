using Npoi.Mapper;
using Nextify.Excel;
using System.Collections.Generic;

namespace Nextify.Excel
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
