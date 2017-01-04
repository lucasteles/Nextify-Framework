using Pragma.Files;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace PGM.Xml
{
    public class XmlTool
    {
        IFileHelper FileHelp = new FileHelper();
        MemoryStream XmlBuffer;
        /// <summary>
        /// Coloca o conteúdo de um arquivo no buffer XML.
        /// </summary>
        /// <param name="tFileName">Caminho do arquivo.</param>
        public void SetXmlFile(string tFileName)
        {
            var cXml = "";
            FileHelp.Upload(tFileName);

            cXml = FileHelp.ToString();
            SetXmlBuffer(cXml);
        }
        /// <summary>
        /// Cria um stream de bytes a partir de uma string e armazena no <see cref="XmlBuffer"/>.
        /// </summary>
        /// <param name="tXml">String a ser convertida.</param>
        public void SetXmlBuffer(string tXml)
        {
            // converte para bytes
            var byteArray = Encoding.UTF8.GetBytes(tXml);
            // cria um stream dos bytes
            XmlBuffer = new MemoryStream(byteArray);
        }
        /// <summary>
        /// Serializa um objeto para uma string.
        /// </summary>
        /// <param name="tObj">Objeto a ser serializado.</param>
        /// <param name="tRoot">Nome da Raiz do XML</param>
        /// <typeparam name="T">Classe do objeto.</typeparam>
        /// <returns>Retorna a serialização do objeto como uma string.</returns>
        public static string Serialize2String<T>(T tObj)
        {
            var oSerializer = new XmlSerializer(typeof(T));

            using (StringWriter oWriter = new StringWriter())
            {
                oSerializer.Serialize(oWriter, tObj);
                return oWriter.ToString();
            }
        }
        /// <summary>
        /// deserializa uma sting para um objeto.
        /// </summary>
        /// <param name="tXml">string que será deserializada</param>
        /// <param name="useUTF8Encoding">todo: describe useUTF8Encoding parameter on String2Deserialize</param>
        /// <typeparam name="T">Classe do objeto.</typeparam>
        /// <returns>Retorna a string como objeto</returns>
        public T String2Deserialize<T>(string tXml, bool useUTF8Encoding = false)
        {
            // Para strigs o Unicode é diferente do UTF-8
            if (useUTF8Encoding)
                XmlBuffer = new MemoryStream(Encoding.UTF8.GetBytes(tXml));
            else
                XmlBuffer = new MemoryStream(Encoding.Unicode.GetBytes(tXml));

            return Deserialize<T>();
        }

        /// <summary>
        /// Serializa um objeto para um arquivo.
        /// </summary>
        /// <typeparam name="T">Classe do objeto.</typeparam>
        /// <param name="tObj">Objeto a ser serializado.</param>
        /// <param name="tFileName">Caminho do arquivo.</param>
        public static void Serialize<T>(T tObj, string tFileName)
        {
            var oSerializer = new XmlSerializer(typeof(T));
            TextWriter oWriter = new StreamWriter(tFileName);
            oSerializer.Serialize(oWriter, tObj);
            oWriter.Close();
        }
        /// <summary>
        /// Desserializa um arquivo para um objeto.
        /// </summary>
        /// <param name="tFileName">Caminho do arquivo.</param>
        /// <param name="ignoreNamespaces">Indica se os namespaces devem ser ignorados.</param>
        /// <typeparam name="T">Tipo do objeto.</typeparam>
        /// <returns>Retorna o objeto desserializado.</returns>
        public T Deserialize<T>(string tFileName, bool ignoreNamespaces = false)
        {
            FileHelp.Upload(tFileName);
            var content = FileHelp.ToString();

            if (ignoreNamespaces)
                content = Regex.Replace(content, @"\s*xmlns(:\w+)?=""([^""]+)""|xsi(:\w+)?=""([^""]+)""", "");

            SetXmlBuffer(content);

            return Deserialize<T>();
        }
        /// <summary>
        /// Desserializa para um objeto a partir do buffer XML.
        /// </summary>
        /// <typeparam name="T">Tipo do objeto.</typeparam>
        /// <returns>Retorna o objeto desserializado.</returns>
        public T Deserialize<T>()
        {
            var oSerializer = new XmlSerializer(typeof(T));

            var lReturn = (T)oSerializer.Deserialize(XmlBuffer);

            return lReturn;
        }
    }
}
