using System.Text;
using System.Web;

namespace FSC_CNest.Extensions
{
    public static class EncodeDecode
    {
        public static string EncodeBase64(this string value)
        {
            var bytes = CNestSettings.Encoding.GetBytes(value);
            return Convert.ToBase64String(bytes);
        }

        public static string DecodeBase64(this string value)
        {
            var text = Convert.FromBase64String(value);
            return CNestSettings.Encoding.GetString(text);
        }

        public static string EncodeUrl(this string value)
        {
            return HttpUtility.UrlEncode(value, CNestSettings.Encoding);
        }

        public static string? DecodeUrl(this string value)
        {
            return HttpUtility.UrlDecode(value, CNestSettings.Encoding);
        }
    }
}
