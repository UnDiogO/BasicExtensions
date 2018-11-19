using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicExtensions
{
    /// <summary>
    /// Class with extensions to ICollection
    /// </summary>
    public static class ICollectionExtensions
    {
        /// <summary>
        /// Add an item to the <see cref="ICollection{T}"/> if it's not already in the collection
        /// </summary>
        /// <typeparam name="T">Type of collection item</typeparam>
        /// <param name="collection">Collection to be evaluated</param>
        /// <param name="item">Item to check and add</param>
        /// <returns>Returns True if added, returns False if not</returns>
        public static bool AddIfNotContains<T>(this ICollection<T> collection, T item)
        {
            if (collection.Contains(item))
            {
                return false;
            }
            collection.Add(item);
            return true;
        }

        /// <summary>
        /// Indicates whether the current <see cref="ICollection{T}"/> is null or an Empty collection
        /// </summary>
        /// <param name="collection">Collection to be evaluated</param>
        /// <returns>Return true whether the current <see cref="ICollection{T}"/> is null or an Empty collection</returns>
        public static bool IsNullOrEmpty<T>(this ICollection<T> collection) =>
            collection == null || collection.Count == 0;

        /// <summary>
        /// Get a random element
        /// </summary>
        /// <typeparam name="T">Type of collection items</typeparam>
        /// <param name="collection">Collection to be evaluated</param>
        /// <exception cref="NullReferenceException"></exception>
        /// <returns>Return a random element</returns>
        public static T GetRandElement<T>(this ICollection<T> collection)
        {
            var rand = new Random();
            return collection.ElementAt(rand.Next(collection.Count));
        }
    }
}