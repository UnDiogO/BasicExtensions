using System;

namespace BasicExtensions
{
    /// <summary>
    /// Class with extensions to IComparable
    /// </summary>
    public static class IComparableExtensions
    {
        /// <summary>
        /// Clamps a value between a minimum and maximum values
        /// </summary>
        /// <typeparam name="T">Type of value</typeparam>
        /// <param name="value">Value to be evaluated</param>
        /// <param name="minimum">Minimum value</param>
        /// <param name="maximum">Maximum value</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns>Return a value between a minimum and maximum values</returns>
        public static T Clamp<T>(this T value, T minimum, T maximum) where T : IComparable<T>
        {
            if (value.CompareTo(minimum) < 0)
            {
                return minimum;
            }
            else if (value.CompareTo(maximum) > 0)
            {
                return maximum;
            }
            return value;
        }

        /// <summary>
        /// Indicates whether value is between a lower and upper values
        /// </summary>
        /// <typeparam name="T">Type of value</typeparam>
        /// <param name="value">Value to be evaluated</param>
        /// <param name="lower">Lower value</param>
        /// <param name="upper">Upper value</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns>Return true whether value is between a lower and upper values</returns>
        public static bool IsBetween<T>(this T value, T lower, T upper) where T : IComparable<T> =>
            value.CompareTo(lower) >= 0 && value.CompareTo(upper) <= 0;
    }
}