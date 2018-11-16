using System;
using System.Linq;
using System.Reflection;

namespace BasicExtensions
{
    /// <summary>
    /// Class with extensions to class
    /// </summary>
    public static class ClassExtensions
    {
        /// <summary>
        /// A human-readable string representing the current object
        /// </summary>
        /// <typeparam name="T">Type of object</typeparam>
        /// <param name="object">Object to be evaluated</param>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="TargetParameterCountException"></exception>
        /// <returns>Returns a human-readable string representing the current object</returns>
        public static string ToHumanReadable<T>(this T @object) where T : class
        {
            if (@object == null)
            {
                throw new NullReferenceException();
            }
            var type = typeof(T);
            var propertiesAndValues = type.GetRuntimeProperties()
                .Select(p => $"{p.Name}={p.GetValue(@object)}");
            return $"[{type.Name}: {string.Join(", ", propertiesAndValues)}]";
        }
    }
}