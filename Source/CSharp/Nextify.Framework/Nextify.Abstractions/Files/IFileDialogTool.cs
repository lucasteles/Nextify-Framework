namespace Nextify.Abstraction.Files
{
    public interface IFileDialogTool
    {
        string PutFile(string Extensions, string Title = "Save file");
    }
}