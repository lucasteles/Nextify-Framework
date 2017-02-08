using Nextify.Abstraction.Files;
using Nextify.Abstraction.IOC;
using Nextify.Excel;
using Nextify.Files;

namespace Nextify.App.Binding
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
