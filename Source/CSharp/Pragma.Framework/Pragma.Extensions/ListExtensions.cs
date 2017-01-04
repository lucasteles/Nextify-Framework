using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace Pragma.Extensions
{
    public static class ListExtensions
    {
        /// <summary>
        /// Extension method destinado a facilitar a validação de Lists
        /// </summary>
        /// <typeparam name="T">Type da lista</typeparam>
        /// <param name="list">Lista a comparar</param>
        /// <returns>Retorna se existem elementos</returns>
        public static bool HasElements<T>(this IEnumerable<T> list)
        {
            return
                list != null
                && list.Any();
        }

        /// <summary>
        /// Extension method destinado a "randomizar" listas usando o algoritmo de Fisher-Yates
        /// </summary>
        /// <typeparam name="T">Type da lista</typeparam>
        /// <param name="list">Lista a randomizar os itens</param>
        /// <returns>Lista randomizada</returns>
        public static IList<T> FisherYates<T>(this IList<T> list)
        {
            List<T> shuffledList = new List<T>(list.Count);

            if (list != null)
            {
                int count = list.Count;
                int jumpSize = 200;
                int index = 0;

                while (count > 0)
                {
                    if (count < jumpSize)
                        jumpSize = count;

                    shuffledList.AddRange(FisherYates(list, index, jumpSize));

                    count -= jumpSize;
                    index += jumpSize;
                }
            }

            return shuffledList;
        }

        /// <summary>
        /// Extension method destinado a "randomizar" listas usando o algoritmo de Fisher-Yates
        /// </summary>
        /// <typeparam name="T">Type da lista</typeparam>
        /// <param name="list">Lista a randomizar os iten</param>
        /// <param name="startIndex">Index inicial para randomizar</param>
        /// <param name="count">Quantidade de itens à randomizar</param>
        /// <returns>Lista com quantidade definida de itens randomizados</returns>
        public static IList<T> FisherYates<T>(this IList<T> list, int startIndex, int count)
        {
            IList<T> listTemp = new List<T>();

            if (list != null)
            {
                listTemp = list
                            .Skip(startIndex)
                            .Take(count)
                            .ToList();

                listTemp.Shuffle();
            }

            return listTemp;
        }

        /// <summary>
        /// Extension method destinado a "randomizar" listas usando o algoritmo de Fisher-Yates
        /// </summary>
        /// <typeparam name="T">Type da lista</typeparam>
        /// <param name="list">Lista a randomizar os iten</param>
        public static void Shuffle<T>(this IList<T> list)
        {
            // Provider de random numbers generator
            var randomGenerator = new RNGCryptoServiceProvider();

            // Contador para a quantidade de itens no list
            var itemIndex = list.Count;
            // Enquanto ainda tiver itens não randomizados na lista...
            while (itemIndex > 1)
            {

                var box = new byte[1];
                // Fará enquanto o valor randomizado
                do
                {
                    randomGenerator.GetBytes(box);
                }
                while (box[0] > itemIndex * (Byte.MaxValue / itemIndex));

                var randomIndex = (box[0] % itemIndex);
                itemIndex--;

                // Recupera item com index de destino.
                T value = list[randomIndex];
                // Faz a troca para o index encontrado de forma randomica
                list[randomIndex] = list[itemIndex];
                // Retorna o item recuperado para sua nova posição no vetor
                list[itemIndex] = value;
            }
        }

        ///<summary>Finds the index of the first item matching an expression in an enumerable.</summary>
        ///<param name="items">The enumerable to search.</param>
        ///<param name="predicate">The expression to test the items against.</param>
        ///<returns>The index of the first matching item, or -1 if no items match.</returns>
        public static int FindIndex<T>(this IEnumerable<T> items, Func<T, bool> predicate)
        {
            if (items == null) throw new ArgumentNullException("items");
            if (predicate == null) throw new ArgumentNullException("predicate");

            int retVal = 0;
            foreach (var item in items)
            {
                if (predicate(item)) return retVal;
                retVal++;
            }
            return -1;
        }
        ///<summary>Finds the index of the first occurence of an item in an enumerable.</summary>
        ///<param name="items">The enumerable to search.</param>
        ///<param name="item">The item to find.</param>
        ///<returns>The index of the first matching item, or -1 if the item was not found.</returns>
        public static int IndexOf<T>(this IEnumerable<T> items, T item) { return items.FindIndex(i => EqualityComparer<T>.Default.Equals(item, i)); }
    }
}