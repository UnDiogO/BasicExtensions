using System;
using System.Collections.Generic;

namespace BasicExtensions
{
    /// <summary>
    /// To be added.
    /// </summary>
    public static class IListExtensions
    {
        /// <summary>
        /// To be added.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        public static void RemoveRandElement<T>(this IList<T> collection)
        {
            var rand = new Random();
            collection.RemoveAt(rand.Next(collection.Count));
        }
    }
}