using System;
using System.Globalization;

namespace BasicExtensions
{
    /// <summary>
    /// To be added.
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsWeekend(this DateTime value) => 
            value.DayOfWeek == DayOfWeek.Saturday || value.DayOfWeek == DayOfWeek.Sunday;

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToStringIso(this DateTime value) => 
            value.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
    }
}