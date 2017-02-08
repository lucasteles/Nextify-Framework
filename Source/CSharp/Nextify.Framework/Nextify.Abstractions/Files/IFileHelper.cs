namespace Nextify.Abstraction.Files
{
    public interface IFileHelper
    {
        void Clear();
        void Download(string tPathFile);
        byte[] GetBytes();
        bool IsEmpty();
        void SetContent(byte[] tContentFile);
        string TempFile();
        void Upload(string tPathFile);
        string ToString();
    }
}