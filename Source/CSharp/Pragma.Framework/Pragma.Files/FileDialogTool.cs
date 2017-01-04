using System.IO;
using System.Windows.Forms;

namespace Pragma.Files
{
    public class FileDialogTool : IFileDialogTool
    {

        public string PutFile(string Extensions, string Title = "Save file")
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = Extensions; // "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog.Title = Title; //"Save an Image File";
            saveFileDialog.CheckFileExists = false;
            saveFileDialog.ShowDialog();

            var file = saveFileDialog.FileName;

            if (!Directory.Exists(Path.GetDirectoryName(file)))
                return string.Empty;

            return file;
        }
    }
}
