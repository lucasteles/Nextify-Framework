using Pragma.App.Xml.Models.Anbima4;
using Pragma.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PGM.Xml.Tools.Anbima4
{
    public class ComparadorAnbima4
    {
        readonly List<ComparadorAnbima4Parameter> ListFiles = new List<ComparadorAnbima4Parameter>();
        /// <summary>
        /// Pasta que será o padrão de comparação
        /// </summary>
        public DirectoryInfo PathRaiz { get; set; }
        /// <summary>
        /// Pasta que será comparada com a raiz
        /// </summary>
        public DirectoryInfo PathOld { get; set; }
        /// <summary>
        /// Pasta onde deve lançar os iguais
        /// </summary>
        public DirectoryInfo PathDest { get; set; }
        /// <summary>
        /// Aquivo que tem os arquivos que devem ser ignorados
        /// </summary>
        public string Ignorados { get; set; } = Pragma.App.Xml.Properties.Resources.XML_CodigosIgnorados;
        /// <summary>
        /// Compara o diretorio raiz com o old e move os iguais para a para Dest
        /// </summary>
        public void Comparacao()
        {
            ListFiles.Clear();

            var FilesRaiz = PathRaiz.GetFiles("*.xml");
            var oXml = new XmlTool();

            foreach (FileInfo rfile in FilesRaiz)
            {
                if (ClearIgnore(rfile))
                    continue;

                var AnbRaiz = new XMLAnbima4();

                var Erro = false;
                try
                {
                    AnbRaiz = oXml.Deserialize<XMLAnbima4>(rfile.FullName, true);
                }
                catch (Exception)
                {
                    Erro = true;
                }

                // Verifica se o saldo do Header está zerado
                var header = AnbRaiz.Fundo.Header.FirstOrDefault();
                if (header.PatLiq == 0)
                {
                    // Deleta os arquivos com quantidade zerada
                    if (File.Exists(rfile.FullName))
                        File.Delete(rfile.FullName);
                    continue;
                }

                var filename = rfile.Name.StrExtract("", "_", 1);
                filename += "_" + rfile.Name.StrExtract("_", "_", 1);
                filename += "_*";
                filename += "_" + rfile.Name.StrExtract("_", "", 3);

                var FilesOld = PathOld.GetFiles(filename).OrderByDescending(i => i.Name).Take(1).ToArray();

                var numerro = 0;
                foreach (var ofile in FilesOld)
                {
                    var AnbOld = new XMLAnbima4();

                    try
                    {
                        AnbOld = oXml.Deserialize<XMLAnbima4>(ofile.FullName, true);
                    }
                    catch (Exception)
                    {
                        Erro = true;
                    }

                    if (!Erro)
                    {
                        try
                        {
                            foreach (PropertyInfo Pro in typeof(Fundo).GetProperties())
                            {
                                var ObjRaiz = (IList)Pro.GetValue(AnbRaiz.Fundo);
                                var ObjOld = (IList)Pro.GetValue(AnbOld.Fundo);

                                numerro += ValidTag(ObjRaiz, ObjOld, rfile, ofile);
                            }
                            // se a qauntidade de Debenture não for igual, marca como erro
                            if (AnbRaiz.Fundo.Debenture.Count != AnbOld.Fundo.Debenture.Count)
                                numerro += 1;
                            else
                            {
                                for (int i = 0; i < AnbRaiz.Fundo.Debenture.Count; i++)
                                    numerro += ValidTag(AnbRaiz.Fundo.Debenture[i].Compromisso, AnbOld.Fundo.Debenture[i].Compromisso, rfile, ofile);
                            }
                            if (numerro == 0)
                            {
                                var dirdest = (string)PathDest.FullName;
                                // verifica se o diretorio existe
                                if (!Directory.Exists(dirdest))
                                    Directory.CreateDirectory(dirdest); // cria se nao existe

                                dirdest += '\\' + rfile.Name;
                                if (File.Exists(dirdest))
                                    File.Delete(dirdest);
                                File.Move(rfile.FullName, dirdest);
                            }
                        }
                        catch (Exception)
                        {
                            Erro = true;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Verifica se a tag está igual
        /// </summary>
        /// <param name="tList">Lista da pasta raiz</param>
        /// <param name="tListOld">Lista da pasta Old</param>
        /// <param name="tRaiz">Informações do Arquivo raiz</param>
        /// <param name="tOld">Informações do Arquivo old</param>
        /// <returns></returns>
        int ValidTag(IList tList, IList tListOld, FileInfo tRaiz, FileInfo tOld)
        {
            var numerro = 0;

            if (tList.Count != tListOld.Count)
                numerro++;

            if (numerro == 0)
            {
                for (int i = 0; i < tList.Count; i++)
                {
                    if (!tList[i].PropertiesEqual(tListOld[i]))
                        numerro++;
                }
            }
            if (numerro > 0)
            {
                var oG = new ComparadorAnbima4Parameter();
                var name = tList.GetType().GenericTypeArguments.Single().Name;
                oG.Raizname = tRaiz.Name;
                oG.Raizfullname = tRaiz.FullName;

                oG.Oldname = tOld.Name;
                oG.Oldfullname = tOld.FullName;
                oG.NumError = numerro;
                oG.Tagname = name;
                ListFiles.Add(oG);
            }
            return (numerro);
        }
        /// <summary>
        /// Abre o arquivo raiz selecionado
        /// </summary>
        /// <param name="tG">Item que será aberto</param>
        public static void OpenRaiz(ComparadorAnbima4Parameter tG)
        {
            if (File.Exists(tG.Raizfullname))
                Process.Start(tG.Raizfullname);
        }
        /// <summary>
        /// Abre o arquivo old selecionado
        /// </summary>
        /// <param name="tG">Item que será aberto</param>
        public static void OpenOld(ComparadorAnbima4Parameter tG)
        {
            if (File.Exists(tG.Oldfullname))
                Process.Start(tG.Oldfullname);
        }
        /// <summary>
        /// Limpa os arquivos definidos como ignorados
        /// </summary>
        /// <param name="tFile">Arquivo que será verificado</param>
        /// <returns></returns>
        public bool ClearIgnore(FileInfo tFile)
        {
            if (tFile.Name.PadLeft(2).ToUpper() == "CT" && File.Exists(tFile.FullName))
            {
                if (File.Exists(tFile.FullName))
                    File.Delete(tFile.FullName);
                return true;
            }

            if (Ignorados == "")
                return false;

            var lines = Regex.Split(Ignorados, "\r\n|\r|\n").ToList();

            var file = tFile.Name.StrExtract("_", "", 3).ToUpper();

            foreach (var line in lines)
            {
                // verifica se o final do arquivo é igual ao arquivo atual.
                if (file.Equals(line.ToUpper() + ".XML"))
                {
                    if (File.Exists(tFile.FullName))
                    {
                        File.Delete(tFile.FullName);
                        return true;
                    }
                }
            }
            return false;
        }

        public async Task<IEnumerable<ComparadorAnbima4Parameter>> GetListAsync()
        {
            return await Task.FromResult(ListFiles);
        }
    }
}
