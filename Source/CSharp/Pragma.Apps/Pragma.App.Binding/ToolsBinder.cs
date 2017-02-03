using Pragma.Abstraction.Files;
using Pragma.Abstraction.IOC;
using Pragma.Excel;
using Pragma.Files;

namespace Pragma.App.Binding
{
    public class ToolsBinder : IBinder
    {
        public void SetBinding(IContainer container)
        {
            container.Register<IExcelTool, ExcelTool>();
            container.Register<IFileDialogTool, FileDialogTool>();
        }
    }
}
