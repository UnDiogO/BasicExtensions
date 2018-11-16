using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace BasicExtensions
{
    /// <summary>
    /// Class with extensions to string
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Delete specific strings
        /// </summary>
        /// <param name="value"><see cref="string"/> to be modified</param>
        /// <param name="others">strings to be removed</param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <returns>Return new <see cref="string"/> whitout the specified words</returns>
        public static string Delete(this string value, params string[] others)
        {
            foreach (var other in others)
            {
                value = value.Replace(other, "");
            }
            return value;
        }

        /// <summary>
        /// Indicates whether is made up of characters categorized as a decimal digit
        /// </summary>
        /// <param name="value"><see cref="string"/> to be evaluated</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <returns>Return true whether all characters are digits</returns>
        public static bool IsDigits(this string value) =>
            !value.Any(c => !char.IsDigit(c));

        /// <summary>
        /// Indicates whether is made up of characters categorized as a decimal digit or letters
        /// </summary>
        /// <param name="value"><see cref="string"/> to be evaluated</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <returns>Return true whether all characters are digits or letters</returns>
        public static bool IsLettersOrDigits(this string value) =>
            !value.Any(c => !char.IsLetterOrDigit(c));

        /// <summary>
        /// Convert to non empty
        /// </summary>
        /// <param name="value"><see cref="string"/> to be evaluated</param>
        /// <returns>Return null whether a <see cref="string"/> is empty or white-spaces, otherwise return the <see cref="string"/></returns>
        public static string NotEmpty(this string value) =>
            string.IsNullOrWhiteSpace(value) ? null : value;

        /// <summary>
        /// Remove the number of characters from the end
        /// </summary>
        /// <param name="value"><see cref="string"/> to be evaluated</param>
        /// <param name="length">Length to remove</param>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns>Return a substring removing the end length</returns>
        public static string RemoveEnd(this string value, int length) =>
            value.Length > length ? value.Substring(0, value.Length - length) : string.Empty;

        /// <summary>
        /// Remove the number of characters at startup
        /// </summary>
        /// <param name="value"><see cref="string"/> to be evaluated</param>
        /// <param name="length">Length to remove</param>
        /// <exception cref="NullReferenceException"></exception>
        /// <returns>Return a substring removing the start length</returns>
        public static string RemoveStart(this string value, int length) =>
            value.Length > length ? value.Substring(length) : string.Empty;

        /// <summary>
        /// Swap case of characters
        /// </summary>
        /// <param name="value"><see cref="string"/> to be evaluated</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <returns>Return swap case of characters</returns>
        public static string SwapCase(this string value) =>
            string.Concat(value.Select(c => char.IsLower(c) ? char.ToUpper(c) : char.ToLower(c)));

        /// <summary>
        /// Convert to byte array
        /// </summary>
        /// <param name="value"><see cref="string"/> to be converted</param>
        /// <remarks>Using encoding UTF8</remarks>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="EncoderFallbackException"></exception>
        /// <returns>Return byte array from current <see cref="string"/></returns>
        public static byte[] ToBytes(this string value) =>
            Encoding.UTF8.GetBytes(value);

        /// <summary>
        /// Captalize the text
        /// </summary>
        /// <param name="value"><see cref="string"/> to be evaluated</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <returns>Return the current <see cref="string"/> captalized</returns>
        public static string ToCapitalize(this string value) =>
            $"{value.Substring(0, 1).ToUpper()}{value.Substring(1).ToLower()}";

        /// <summary>
        /// Create a <see cref="string"/> from the current with the specified length filling with white spaces
        /// </summary>
        /// <param name="value"><see cref="string"/> to be evaluated</param>
        /// <param name="length">Length of new <see cref="string"/></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <returns>Return a <see cref="string"/> from the current with the specified length filling with white spaces</returns>
        public static string ToCenter(this string value, int length)
        {
            var spaces = length - value.Length;
            var padLeft = spaces / 2 + value.Length;
            return value.PadLeft(padLeft).PadRight(length);
        }

        /// <summary>
        /// Convert to <see cref="DateTime"/>
        /// </summary>
        /// <param name="value"><see cref="string"/> to be converted</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="FormatException"></exception>
        /// <returns>Return a <see cref="DateTime"/> converted from a <see cref="string"/></returns>
        public static DateTime ToDateTime(this string value) =>
            DateTime.Parse(value);

        /// <summary>
        /// Convert to <see cref="Guid"/>
        /// </summary>
        /// <param name="value"><see cref="string"/> to be converted</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="FormatException"></exception>
        /// <returns>Return a <see cref="Guid"/> converted from a <see cref="string"/></returns>
        public static Guid ToGuid(this string value) =>
            Guid.Parse(value);

        /// <summary>
        /// Generate a <see cref="string"/> with MD5 hash format from the current <see cref="string"/>
        /// </summary>
        /// <param name="value"><see cref="string"/> to be evalauted</param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="EncoderFallbackException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <returns>Return a <see cref="string"/> with MD5 hash format from the current <see cref="string"/></returns>
        public static string ToMd5(this string value)
        {
            using (var md5 = MD5.Create())
            {
                var hash = md5.ComputeHash(value.ToBytes());
                return BitConverter.ToString(hash).Delete("-").ToLower();
            }
        }

        /// <summary>
        /// Convert to <see cref="string"/> with quotes
        /// </summary>
        /// <param name="value"><see cref="string"/> to be evaluated</param>
        /// <returns>Return a <see cref="string"/> with quotes from the current <see cref="string"/></returns>
        public static string ToQuote(this string value) =>
            $"\"{value}\"";

        /// <summary>
        /// Create a <see cref="string"/> 'null' whether the current <see cref="string"/> is null
        /// </summary>
        /// <param name="value"><see cref="string"/> to be evaluated</param>
        /// <returns>Return a <see cref="string"/> 'null' whether the current <see cref="string"/> is null</returns>
        public static string ToStringNull(this string value) =>
            value ?? "null";

        /// <summary>
        /// Convert to a title case
        /// </summary>
        /// <param name="value"><see cref="string"/> to be evaluated</param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <returns>Return title case of <see cref="string"/></returns>
        public static string ToTitleCase(this string value) =>
            string.Join(" ", value.Split(' ').Select(s => s.ToCapitalize()));

        /// <summary>
        /// Truncate the current <see cref="string"/>
        /// </summary>
        /// <param name="value"><see cref="string"/> to be evaluated</param>
        /// <param name="maxLength">Maximum length of the <see cref="string"/></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        /// <returns>Return tue current <see cref="string"/> truncated</returns>
        public static string Truncate(this string value, int maxLength) =>
            value.Length <= maxLength ? value : value.Substring(0, maxLength) + "…";
    }
}