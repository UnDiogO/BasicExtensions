using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace BasicExtensions
{
    /// <summary>
    /// To be added.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="others"></param>
        /// <returns></returns>
        public static string Delete(this string value, params string[] others)
        {
            foreach (var other in others)
            {
                value = value.Replace(other, "");
            }
            return value;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsDigits(this string value) =>
            !value.Any(c => !char.IsDigit(c));

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsLettersOrDigits(this string value) =>
            !value.Any(c => !char.IsLetterOrDigit(c));

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string NotEmpty(this string value) =>
            string.IsNullOrWhiteSpace(value) ? null : value;

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string RemoveEnd(this string value, int length) =>
            value.Length > length ? value.Substring(0, value.Length - length) : string.Empty;

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string RemoveStart(this string value, int length) =>
            value.Length > length ? value.Substring(length) : string.Empty;

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string SwapCase(this string value) =>
            string.Concat(value.Select(c => char.IsLower(c) ? char.ToUpper(c) : char.ToLower(c)));

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static byte[] ToBytes(this string value) =>
            Encoding.UTF8.GetBytes(value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToCapitalize(this string value) =>
            $"{value.Substring(0, 1).ToUpper()}{value.Substring(1).ToLower()}";

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string ToCenter(this string value, int length)
        {
            var spaces = length - value.Length;
            var padLeft = spaces / 2 + value.Length;
            return value.PadLeft(padLeft).PadRight(length);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DateTime ToDateTime(this string value) =>
            DateTime.Parse(value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Guid ToGuid(this string value) =>
            Guid.Parse(value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToMd5(this string value)
        {
            try
            {
                using (var md5 = MD5.Create())
                {
                    var hash = md5.ComputeHash(value.ToBytes());
                    return BitConverter.ToString(hash).Delete("-").ToLower();
                }
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToQuote(this string value) =>
            $"\"{value}\"";

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToStringNull(this string value) =>
            value == null ? "null" : value.ToString();

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToTitleCase(this string value) =>
            string.Join(" ", value.Split(' ').Select(s => s.ToCapitalize()));

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="maxLength"></param>
        /// <returns></returns>
        public static string Truncate(this string value, int maxLength) =>
            value.Substring(0, maxLength);
    }
}