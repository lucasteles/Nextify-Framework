namespace Nextify.Extensions
{
    public static class IntExtensions
    {

        /// <summary>
        /// Completa o numero com zeros a esquerda
        /// </summary>
        /// <param name="tTam">Tamanho maximo da string</param>
        /// <param name="tNum">Numero de referencia</param>
        /// <returns>Retorna o numero como string</returns>
        public static string StrZero(this int tNum, int tTam)
        {
            return tNum.ToString("0".Replicate(tTam)); ;
        }
        /// <summary>
        /// Completa o numero com zeros a esquerda
        /// </summary>
        /// <param name="tTam">Tamanho maximo da string</param>
        /// <param name="tNum">Numero de referencia</param>
        /// <returns>Retorna o numero como string</returns>
        public static string StrZero(this decimal tNum, int tTam)
        {
            return tNum.ToString("0".Replicate(tTam)); ;
        }
    }
}