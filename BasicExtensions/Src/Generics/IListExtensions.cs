using System;
using System.Collections.Generic;

namespace BasicExtensions
{
    /// <summary>
    /// Class with extensions to IList
    /// </summary>
    public static class IListExtensions
    {
        /// <summary>
        /// Remove a random element
        /// </summary>
        /// <typeparam name="T">Type of collection items</typeparam>
        /// <param name="collection">Collection to be evaluated</param>
        /// <exception cref="NullReferenceException"></exception>
        public static void RemoveRandElement<T>(this IList<T> collection)
        {
            var rand = new Random();
            collection.RemoveAt(rand.Next(collection.Count));
        }
    }
}