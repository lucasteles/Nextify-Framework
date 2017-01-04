using Pragma.Excel;
using Pragma.Files;
using Pragma.IOC;
using Pragma.IOC.Abstraction;

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
