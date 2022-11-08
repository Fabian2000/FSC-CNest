using System;
using System.Text;
using System.Web;

namespace FSC_CNest.Extensions
{
    public static class EncodeDecode
    {
        /// <summary>
        /// Encodes a string to base64
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string EncodeBase64(this string value)
        {
            var bytes = CNestSettings.Encoding.GetBytes(value);
            return Convert.ToBase64String(bytes);
        }

        /// <summary>
        /// Decodes a base64 string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string DecodeBase64(this string value)
        {
            var text = Convert.FromBase64String(value);
            return CNestSettings.Encoding.GetString(text);
        }

#if NET6_0_OR_GREATER || NETSTANDARD1_0_OR_GREATER
        /// <summary>
        /// Encodes an URL
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string EncodeUrl(this string value)
        {
            return HttpUtility.UrlEncode(value, CNestSettings.Encoding);
        }

        /// <summary>
        /// Decodes an URL
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string? DecodeUrl(this string value)
        {
            return HttpUtility.UrlDecode(value, CNestSettings.Encoding);
        }
#endif
    }
}
