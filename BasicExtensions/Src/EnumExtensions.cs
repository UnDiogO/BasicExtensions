using System;

namespace BasicExtensions
{
    /// <summary>
    /// Class with extensions to Enum
    /// </summary>
    public static class EnumExtensions
    {
        /// <summary>
        /// Convert to <see cref="int"/>
        /// </summary>
        /// <param name="value">Enum item to evaluated</param>
        /// <exception cref="FormatException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <exception cref="OverflowException"></exception>
        /// <returns>Return an <see cref="int"/> representing the enum item</returns>
        public static int ToInt(this Enum value) =>
            Convert.ToInt32(value);
    }
}
