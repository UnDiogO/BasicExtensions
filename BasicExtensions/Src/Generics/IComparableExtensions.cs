using System;

namespace BasicExtensions
{
    /// <summary>
    /// To be added.
    /// </summary>
    public static class IComparableExtensions
    {
        /// <summary>
        /// To be added.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static T Clamp<T>(this T value, T min, T max) where T : IComparable<T>
        {
            if (value.CompareTo(min) < 0)
            {
                return min;
            }
            else if (value.CompareTo(max) > 0)
            {
                return max;
            }
            return value;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        public static bool IsBetween<T>(this T value, T lower, T upper) where T : IComparable<T> =>
            value.CompareTo(lower) >= 0 && value.CompareTo(upper) <= 0;
    }
}