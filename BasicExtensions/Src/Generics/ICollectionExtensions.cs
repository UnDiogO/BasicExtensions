using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicExtensions
{
    /// <summary>
    /// To be added.
    /// </summary>
    public static class ICollectionExtensions
    {
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty<T>(this ICollection<T> collection) =>
            collection == null || collection.Count == 0;

        /// <summary>
        /// To be added.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static T GetRandElement<T>(this ICollection<T> collection)
        {
            var rand = new Random();
            return collection.ElementAt(rand.Next(collection.Count));
        }
    }
}