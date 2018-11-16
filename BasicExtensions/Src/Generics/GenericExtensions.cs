using System;
using System.Linq;

namespace BasicExtensions
{
    /// <summary>
    /// Class with extensions to generic type
    /// </summary>
    public static class GenericExtensions
    {
        /// <summary>
        /// Indicates whether the current object is contained in the values
        /// </summary>
        /// <typeparam name="T">Type of object</typeparam>
        /// <param name="object">Object to be evaluated</param>
        /// <param name="values">Collection to be evaluated</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns>Return true whether the current object is contained in the values</returns>
        public static bool In<T>(this T @object, params T[] values) =>
            values.Contains(@object);
    }
}
