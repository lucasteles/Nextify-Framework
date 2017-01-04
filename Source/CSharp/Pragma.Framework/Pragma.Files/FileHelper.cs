using System.IO;
using System.Linq;
using System.Text;

namespace Pragma.Files
{
    /// <summary>
    /// Controlador de arquivos
    /// </summary>
    public class FileHelper : IFileHelper
    {
        /// <summary>
        /// Bytes do conteudo do arquivo
        /// </summary>
        byte[] Content { get; set; }
        /// <summary>
        /// Carrega o conteudo do arquivo como bytes
        /// </summary>
        /// <param name="tPathFile">Caminho do arquivo que será carregado</param>
        public void Upload(string tPathFile)
        {
            if (!File.Exists(tPathFile))
                return;

            var fs = new FileStream(tPathFile,
                                    FileMode.Open,
                                    FileAccess.Read);

            using (var br = new BinaryReader(fs, Encoding.Unicode))
            {
                var numBytes = new FileInfo(tPathFile).Length;

                Content = br.ReadBytes((int)numBytes);
            }
            fs.Close();
        }
        /// <summary>
        /// Salva o conteudo em um determinado caminho
        /// </summary>
        /// <param name="tPathFile">Caminho que o arquivo será salvo</param>
        public void Download(string tPathFile)
        {
            using (var fs = new FileStream(tPathFile, FileMode.Create))
            {
                fs.Write(Content, 0, Content.Length);
                fs.Close();
            }
        }
        /// <summary>
        /// Salva o conteudo em um arquivo temporario na pasta temporaria do usuario
        /// </summary>
        public string TempFile()
        {
            var PathFile = Path.GetTempFileName();

            using (var fs = new FileStream(PathFile, FileMode.Create))
            {
                fs.Write(Content, 0, Content.Length);
                fs.Close();
            }
            return PathFile;
        }
        /// <summary>
        /// Define um conteudo para controle
        /// </summary>
        /// <param name="tContentFile">bytes do conteudo do arquivo</param>
        public void SetContent(byte[] tContentFile)
        {
            Content = tContentFile;
        }
        /// <summary>
        /// Limpa o conteudo carregado
        /// </summary>
        public void Clear()
        {
            Content = null;
        }
        /// <summary>
        /// Indica se o conteudo está vazio
        /// </summary>
        /// <returns>Verdadeiro se estiver vazio</returns>
        public bool IsEmpty()
        {
            if (Content == null)
                return true;

            return Content.Count() == 0;
        }
        /// <summary>
        /// Retorna bytes do conteudo
        /// </summary>
        /// <returns>array de bytes</returns>
        public byte[] GetBytes()
        {
            return Content;
        }
        /// <summary>
        /// Converte o conteudo do arquivo para string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return System.Text.Encoding.UTF8.GetString(Content);
        }
    }
}
