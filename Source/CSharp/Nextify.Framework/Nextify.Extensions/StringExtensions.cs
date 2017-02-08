using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Nextify.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Extension method para remover caracteres especiais de uma string.
        /// </summary>
        /// <param name="dirtyString">string com o conteúdo a avaliar </param>
        /// <returns>string limpa de caracteres especiais</returns>
        public static string RemoveSpecialChars(this string dirtyString)
        {
            var sbuilder = new StringBuilder();
            if (!string.IsNullOrEmpty(dirtyString))
            {
                var acceptableChars = "áàâêäéèêëíìîïóòõôöúùûüÁÀÃÂÄÉÈÊËÍÌÎÏÓÒÔÕÖÚÙÛÜ";
                sbuilder = new StringBuilder(dirtyString.Length);

                for (int i = 0; i < dirtyString.Length; i++)
                {
                    var c = dirtyString[i];

                    if (c.Equals(' ')
                        || (c >= '0' && c <= '9')
                        || (c >= 'A' && c <= 'Z')
                        || (c >= 'a' && c <= 'z')
                        || acceptableChars.Contains(c))
                    {
                        sbuilder.Append(c);
                    }
                }
            }

            return sbuilder.ToString();
        }

        /// <summary>
        /// Extension method para trocar caracteres especiais em simples. (ex: á para a)
        /// </summary>
        /// <param name="dirtyString">string com o conteúdo a avaliar </param>
        /// <returns>string limpa de caracteres especiais</returns>
        public static string ReplaceSpecialChars(this string dirtyString)
        {
            Regex objRex = null;
            var ht = new Dictionary<string, string>();
            var sOut = string.Empty;

            try
            {
                sOut = dirtyString;

                ht.Add("A", @"Á|À|Â|Ã|Ä|Å|Æ|æ");
                ht.Add("a", @"á|à|â|ã|ª");
                ht.Add("E", @"É|È|Ê|Ë");
                ht.Add("e", @"é|è|ê|ë");
                ht.Add("I", @"Í|Ì|Î|Ï");
                ht.Add("i", @"í|ì|î|ï");
                ht.Add("O", @"Ó|Ò|Ô|Õ");
                ht.Add("o", @"ó|ò|ô|õ|º|ö");
                ht.Add("U", @"Ú|Ù|Û|Ü");
                ht.Add("u", @"ú|ù|û|ü");
                ht.Add("C", @"Ç");
                ht.Add("c", @"ç");
                ht.Add(string.Empty, @",|\.|-|/|&|'|´");

                foreach (string Key in ht.Keys)
                {
                    objRex = new System.Text.RegularExpressions.Regex(ht[Key]);
                    sOut = objRex.Replace(sOut, Key);
                }

                return sOut;
            }
            finally
            {
                objRex = null;
                ht = null;
            }
        }

        /// <summary>
        /// Extension method destinado a encontrar itens com patterns de REGEX
        /// </summary>
        /// <param name="text">Texto contendo string para like</param>
        /// <param name="pattern">Pattern utilizado no like</param>
        /// <param name="options">Opções para o REGEX</param>
        /// <returns>Retorna se existe itens para a condição de REGEX</returns>
        public static bool Like(
            this string text,
            string pattern,
            RegexOptions options = RegexOptions.IgnoreCase
        )
        {
            return Regex.IsMatch(text, pattern, options);
        }

        /// <summary>
        /// Método responsável por modificar caracteres especiais pelos relativos escapes
        /// </summary>
        /// <param name="items">Lista de itens a aplicar escapes</param>
        /// <returns>Lista com os escapes aplicados</returns>
        private static IList<String> EscapeItems(IList<String> items)
        {
            if (items == null)
            {
                throw new ArgumentNullException();
            }

            items = new List<String>(items);

            for (int i = 0; i < items.Count; i++)
            {
                if (items[i] == null || (items[i] = items[i].Trim()).Length == 0)
                {
                    items.RemoveAt(i--);
                }
                else
                {
                    items[i] = Regex.Escape(items[i]);
                }
            }

            return items;
        }

        /// <summary>
        /// Receives a string expression and a numeric value indicating number of time
        /// and replicates that string for the specified number of times.
        /// <pre>
        /// Example:
        /// VFPToolkit.strings.Replicate("Joe", 5); //returns JoeJoeJoeJoeJoe
        ///
        /// Tip: Use a StringBuilder when lengthy string manipulations are required.
        /// </pre>
        /// </summary>
        /// <param name="cExpression"> </param>
        /// <param name="nTimes"> </param>
        public static string Replicate(this string cExpression, int nTimes)
        {
            //Create a stringBuilder
            var sb = new StringBuilder();
            //Insert the expression into the StringBuilder for nTimes
            sb.Insert(0, cExpression, nTimes);
            //Convert it to a string and return it back
            return sb.ToString();
        }

        /// <summary>
        /// Receives a string along with starting and ending delimiters and returns the
        /// part of the string between the delimiters. Receives a beginning occurence
        /// to begin the extraction from and also receives a flag (0/1) where 1 indicates
        /// that the search should be case insensitive.
        /// <pre>
        /// Example:
        /// string cExpression = "JoeDoeJoeDoe";
        /// VFPToolkit.strings.StrExtract(cExpression, "o", "eJ", 1, 0); //returns "eDo"
        /// </pre>
        /// </summary>
        /// <param name="cSearchExpression">todo: describe cSearchExpression parameter on StrExtract</param>
        /// <param name="cBeginDelim">todo: describe cBeginDelim parameter on StrExtract</param>
        /// <param name="cEndDelim">todo: describe cEndDelim parameter on StrExtract</param>
        /// <param name="nBeginOccurence">todo: describe nBeginOccurence parameter on StrExtract</param>
        /// <param name="nFlags">todo: describe nFlags parameter on StrExtract</param>
        public static string StrExtract(this string cSearchExpression, string cBeginDelim, string cEndDelim, int nBeginOccurence, int nFlags)
        {
            var cstring = cSearchExpression;
            var cb = cBeginDelim;
            var ce = cEndDelim;
            var lcRetVal = "";
            //Check for case-sensitive or insensitive search
            if (nFlags == 1)
            {
                cstring = cstring.ToLower();
                cb = cb.ToLower();
                ce = ce.ToLower();
            }
            //Lookup the position in the string
            var nbpos = At(cb, cstring, nBeginOccurence) + cb.Length - 1;
            var nepos = cSearchExpression.Length;

            if (!string.IsNullOrEmpty(ce))
                nepos = cstring.IndexOf(ce, nbpos + 1);

            //Extract the part of the strign if we get it right
            if (nepos > nbpos)
            {
                lcRetVal = cSearchExpression.Substring(nbpos, nepos - nbpos);
            }
            return lcRetVal;
        }

        /// <summary>
        /// Receives a string and a delimiter as parameters and returns a string starting
        /// from the position after the delimiter
        /// <pre>
        /// Example:
        /// string cExpression = "JoeDoeJoeDoe";
        /// VFPToolkit.strings.StrExtract(cExpression, "o"); //returns "eDoeJoeDoe"
        /// </pre>
        /// </summary>
        /// <param name="cSearchExpression"> </param>
        /// <param name="cBeginDelim"> </param>
        public static string StrExtract(this string cSearchExpression, string cBeginDelim)
        {
            var nbpos = At(cSearchExpression, cBeginDelim);
            return cSearchExpression.Substring(nbpos + cBeginDelim.Length - 1);
        }
        /// <summary>
        /// Receives a string along with starting and ending delimiters and returns the
        /// part of the string between the delimiters
        /// <pre>
        /// Example:
        /// string cExpression = "JoeDoeJoeDoe";
        /// VFPToolkit.strings.StrExtract(cExpression, "o", "eJ"); //returns "eDo"
        /// </pre>
        /// </summary>
        /// <param name="cSearchExpression"> </param>
        /// <param name="cBeginDelim"> </param>
        /// <param name="cEndDelim"> </param>
        public static string StrExtract(this string cSearchExpression, string cBeginDelim, string cEndDelim)
        {
            return StrExtract(cSearchExpression, cBeginDelim, cEndDelim, 1, 0);
        }
        /// <summary>
        /// Receives a string along with starting and ending delimiters and returns the
        /// part of the string between the delimiters. It also receives a beginning occurence
        /// to begin the extraction from.
        /// <pre>
        /// Example:
        /// string cExpression = "JoeDoeJoeDoe";
        /// VFPToolkit.strings.StrExtract(cExpression, "o", "eJ", 2); //returns ""
        /// </pre>
        /// </summary>
        /// <param name="cSearchExpression"> </param>
        /// <param name="cBeginDelim"> </param>
        /// <param name="cEndDelim"> </param>
        /// <param name="nBeginOccurence"> </param>
        public static string StrExtract(this string cSearchExpression, string cBeginDelim, string cEndDelim, int nBeginOccurence)
        {
            return StrExtract(cSearchExpression, cBeginDelim, cEndDelim, nBeginOccurence, 0);
        }

        /// <summary>
        /// Receives two strings as parameters and searches for one string within another.
        /// If found, returns the beginning numeric position otherwise returns 0
        /// <pre>
        /// Example:
        /// VFPToolkit.strings.At("D", "Joe Doe"); //returns 5
        /// </pre>
        /// </summary>
        /// <param name="cSearchFor"> </param>
        /// <param name="cSearchIn"> </param>
        public static int At(this string cSearchIn, string cSearchFor)
        {
            return cSearchIn.IndexOf(cSearchFor) + 1;
        }
        /// <summary>
        /// Receives two strings and an occurence position (1st, 2nd etc) as parameters and
        /// searches for one string within another for that position.
        /// If found, returns the beginning numeric position otherwise returns 0
        /// <pre>
        /// Example:
        /// VFPToolkit.strings.At("o", "Joe Doe", 1); //returns 2
        /// VFPToolkit.strings.At("o", "Joe Doe", 2); //returns 6
        /// </pre>
        /// </summary>
        /// <param name="cSearchFor"> </param>
        /// <param name="cSearchIn"> </param>
        /// <param name="nOccurence"> </param>
        public static int At(this string cSearchIn, string cSearchFor, int nOccurence)
        {
            return __at(cSearchFor, cSearchIn, nOccurence, 1);
        }
        /// <param name="cSearchIn">todo: describe cSearchIn parameter on __at</param>
        /// <param name="cSearchFor">todo: describe cSearchFor parameter on __at</param>
        /// <param name="nOccurence">todo: describe nOccurence parameter on __at</param>
        /// <param name="nMode">todo: describe nMode parameter on __at</param>
        private static int __at(this string cSearchIn, string cSearchFor, int nOccurence, int nMode)
        {
            //In this case we actually have to locate the occurence
            var i = 0;
            var nOccured = 0;
            var nPos = 0;
            nPos = nMode == 1 ? 0 : cSearchIn.Length;
            //Loop through the string and get the position of the requiref occurence
            for (i = 1; i <= nOccurence; i++)
            {
                nPos = nMode == 1 ? cSearchIn.IndexOf(cSearchFor, nPos) : cSearchIn.LastIndexOf(cSearchFor, nPos);
                if (nPos < 0)
                {
                    //This means that we did not find the item
                    break;
                }
                else
                {
                    //Increment the occured counter based on the current mode we are in
                    nOccured++;
                    //Check if this is the occurence we are looking for
                    if (nOccured == nOccurence)
                    {
                        return nPos + 1;
                    }
                    else
                    {
                        if (nMode == 1) { nPos++; }
                        else { nPos--; }
                    }
                }
            }
            //We never found our guy if we reached here
            return 0;
        }
        /// <summary>
        /// Receives two strings as parameters and searches for one string within another.
        /// This function ignores the case and if found, returns the beginning numeric position
        /// otherwise returns 0
        /// <pre>
        /// Example:
        /// VFPToolkit.strings.AtC("d", "Joe Doe"); //returns 5
        /// </pre>
        /// </summary>
        /// <param name="cSearchFor"> </param>
        /// <param name="cSearchIn"> </param>
        public static int AtC(this string cSearchIn, string cSearchFor)
        {
            return cSearchIn.ToLower().IndexOf(cSearchFor.ToLower()) + 1;
        }
        /// <summary>
        /// Receives two strings and an occurence position (1st, 2nd etc) as parameters and
        /// searches for one string within another for that position. This function ignores the
        /// case of both the strings and if found, returns the beginning numeric position
        /// otherwise returns 0.
        /// <pre>
        /// Example:
        /// VFPToolkit.strings.AtC("d", "Joe Doe", 1); //returns 5
        /// VFPToolkit.strings.AtC("O", "Joe Doe", 2); //returns 6
        /// </pre>
        /// </summary>
        /// <param name="cSearchFor"> </param>
        /// <param name="cSearchIn"> </param>
        /// <param name="nOccurence"> </param>
        public static int AtC(this string cSearchIn, string cSearchFor, int nOccurence)
        {
            return __at(cSearchFor.ToLower(), cSearchIn.ToLower(), nOccurence, 1);
        }

        /// <summary>
        /// Returns the number of occurences of a character within a string
        /// <pre>
        /// Example:
        /// VFPToolkit.strings.Occurs('o', "Joe Doe"); //returns 2
        ///
        /// Tip: If we have a string say lcString, then lcString[3] gives us the 3rd character in the string
        /// </pre>
        /// </summary>
        /// <param name="cExpression"> </param>
        /// <param name="tcChar">todo: describe tcChar parameter on Occurs</param>
        public static int Occurs(this char tcChar, string cExpression)
        {
            int i, nOccured = 0;
            //Loop through the string
            for (i = 0; i < cExpression.Length; i++)
            {
                //Check if each expression is equal to the one we want to check against
                if (cExpression[i] == tcChar)
                {
                    //if so increment the counter
                    nOccured++;
                }
            }
            return nOccured;
        }
        /// <summary>
        /// Returns the number of occurences of a character within a string
        /// <pre>
        /// Example:
        /// VFPToolkit.strings.Occurs('o', "Joe Doe"); //returns 2
        ///
        /// Tip: If we have a string say lcString, then lcString[3] gives us the 3rd character in the string
        /// </pre>
        /// </summary>
        /// <param name="cExpression"> </param>
        /// <param name="cString">todo: describe cString parameter on Occurs</param>
        public static int Occurs(this string cString, string cExpression)
        {
            var nPos = 0;
            var nOccured = 0;
            do
            {
                //Look for the search string in the expression
                nPos = cExpression.IndexOf(cString, nPos);
                if (nPos < 0)
                {
                    //This means that we did not find the item
                    break;
                }
                else
                {
                    //Increment the occured counter based on the current mode we are in
                    nOccured++;
                    nPos++;
                }
            } while (true);
            //Return the number of occurences
            return nOccured;
        }
        /// <summary>
        /// Receives a string and the length of the result string as parameters. Pads blank
        /// characters on the both sides of this string and returns a string with the length specified.
        /// <pre>
        /// Example:
        /// VFPToolkit.strings.PadL("Joe Doe", 10); //returns " Joe Doe "
        /// </pre>
        /// </summary>
        /// <param name="cExpression"> </param>
        /// <param name="nResultSize"> </param>
        public static string PadC(this string cExpression, int nResultSize)
        {
            //Determine the number of padding characters
            var nPaddTotal = nResultSize - cExpression.Length;
            var lnHalfLength = (int)(nPaddTotal / 2);
            var lcString = PadL(cExpression, cExpression.Length + lnHalfLength);
            return lcString.PadRight(nResultSize);
        }
        /// <summary>
        /// Receives a string, the length of the result string and the padding character as
        /// parameters. Pads the padding character on both sides of this string and returns a string
        /// with the length specified.
        /// <pre>
        /// Example:
        /// VFPToolkit.strings.PadL("Joe Doe", 10, 'x'); //returns "xJoe Doexx"
        /// </pre>
        /// </summary>
        /// <param name="cExpression"> </param>
        /// <param name="nResultSize"> </param>
        /// <param name="cPaddingChar"> </param>
        public static string PadC(this string cExpression, int nResultSize, char cPaddingChar)
        {
            //Determine the number of padding characters
            var nPaddTotal = nResultSize - cExpression.Length;
            var lnHalfLength = (int)(nPaddTotal / 2);
            var lcString = PadL(cExpression, cExpression.Length + lnHalfLength, cPaddingChar);
            return lcString.PadRight(nResultSize, cPaddingChar);
        }
        /// <summary>
        /// Receives a string and the length of the result string as parameters. Pads blank
        /// characters on the left of this string and returns a string with the length specified.
        /// <pre>
        /// Example:
        /// VFPToolkit.strings.PadL("Joe Doe", 10); //returns " Joe Doe"
        /// </pre>
        /// </summary>
        /// <param name="cExpression"> </param>
        /// <param name="nResultSize"> </param>
        public static string PadL(this string cExpression, int nResultSize)
        { return cExpression.PadLeft(nResultSize); }
        /// <summary>
        /// Receives a string, the length of the result string and the padding character as
        /// parameters. Pads the padding character on the left of this string and returns a string
        /// with the length specified.
        /// <pre>
        /// Example:
        /// VFPToolkit.strings.PadL("Joe Doe", 10, 'x'); //returns "xxxJoe Doe"
        ///
        /// Tip: Use single quote to create a character type data and double quotes for strings
        /// </pre>
        /// </summary>
        /// <param name="cExpression">todo: describe cExpression parameter on PadL</param>
        /// <param name="nResultSize">todo: describe nResultSize parameter on PadL</param>
        /// <param name="cPaddingChar">todo: describe cPaddingChar parameter on PadL</param>
        public static string PadL(this string cExpression, int nResultSize, char cPaddingChar)
        { return cExpression.PadLeft(nResultSize, cPaddingChar); }
        /// <summary>
        /// Receives a string and the length of the result string as parameters. Pads blank
        /// characters on the right of this string and returns a string with the length specified.
        /// <pre>
        /// Example:
        /// VFPToolkit.strings.PadL("Joe Doe", 10); //returns "Joe Doe "
        /// </pre>
        /// </summary>
        /// <param name="cExpression"> </param>
        /// <param name="nResultSize"> </param>
        public static string PadR(this string cExpression, int nResultSize)
        { return cExpression.PadRight(nResultSize); }
        /// <summary>
        /// Receives a string, the length of the result string and the padding character as
        /// parameters. Pads the padding character on the right of this string and returns a string
        /// with the length specified.
        /// <pre>
        /// Example:
        /// VFPToolkit.strings.PadL("Joe Doe", 10, 'x'); //returns "Joe Doexxx"
        ///
        /// Tip: Use single quote to create a character type data and double quotes for strings
        /// </pre>
        /// </summary>
        /// <param name="cExpression"> </param>
        /// <param name="nResultSize"> </param>
        /// <param name="cPaddingChar"> </param>
        public static string PadR(this string cExpression, int nResultSize, char cPaddingChar)
        { return cExpression.PadRight(nResultSize, cPaddingChar); }
        /// <summary>
        /// Receives a string as a parameter and returns the string in Proper format (makes each letter after a space capital)
        /// <pre>
        /// Example:
        /// VFPToolkit.strings.Proper("joe doe is a good man"); //returns "Joe Doe Is A Good Man"
        /// </pre>
        /// </summary>
        /// <param name="cString"> </param>
        public static string Proper(this string cString)
        {
            //Create the StringBuilder
            var sb = new StringBuilder("");
            int i;
            var nLength = cString.Length;
            var ToUpp = false;
            for (i = 0; i < nLength; i++)
            {
                if (i == 0)
                    ToUpp = true;

                if (char.IsWhiteSpace(cString[i]))
                {
                    ToUpp = true;
                    sb.Insert(i, cString[i]);
                    continue;
                }

                if (ToUpp)
                    sb.Insert(i, Char.ToUpper(cString[i]));
                else
                    sb.Insert(i, Char.ToLower(cString[i]));
                ToUpp = false;
            }
            return sb.ToString();
        }

        public static string SetParams(this string theString, params string[] parameters)
        {
            return string.Format(theString, parameters);
        }

    }
}