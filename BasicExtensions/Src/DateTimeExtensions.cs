using System;
using System.Globalization;

namespace BasicExtensions
{
    /// <summary>
    /// Class with extensions to DateTime
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Indicates whether the current <see cref="DateTime"/> is weekend
        /// </summary>
        /// <param name="value"><see cref="DateTime"/> to be evaluated</param>
        /// <returns>Return true whether the current <see cref="DateTime"/> is weekend</returns>
        public static bool IsWeekend(this DateTime value) => 
            value.DayOfWeek == DayOfWeek.Saturday || value.DayOfWeek == DayOfWeek.Sunday;

        /// <summary>
        /// Converts the value of the current <see cref="DateTime"/> object to its equivalent iso string representation
        /// </summary>
        /// <remarks>Format: yyyy-MM-dd HH:mm:ss</remarks>
        /// <param name="value"><see cref="DateTime"/> to be evaluated</param>
        /// <exception cref="FormatException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns>Return the value of the current <see cref="DateTime"/> object to its equivalent iso string representation</returns>
        public static string ToStringIso(this DateTime value) => 
            value.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
    }
}