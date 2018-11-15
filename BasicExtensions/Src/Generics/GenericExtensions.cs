using System.Linq;

namespace BasicExtensions
{
    /// <summary>
    /// To be added.
    /// </summary>
    public static class GenericExtensions
    {
        /// <summary>
        /// To be added.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="object"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static bool In<T>(this T @object, params T[] values) =>
            values.Contains(@object);
    }
}
