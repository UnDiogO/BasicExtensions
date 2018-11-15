using System.Linq;
using System.Reflection;

namespace BasicExtensions
{
    /// <summary>
    /// To be added.
    /// </summary>
    public static class ClassExtensions
    {
        /// <summary>
        /// To be added.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="object"></param>
        /// <returns></returns>
        public static string ToHumanReadable<T>(this T @object) where T : class
        {
            var type = typeof(T);
            var propertiesAndValues = type.GetRuntimeProperties()
                .Select(p => $"{p.Name}={p.GetValue(@object)}");
            return $"[{type.Name}: {string.Join(", ", propertiesAndValues)}]";
        }
    }
}