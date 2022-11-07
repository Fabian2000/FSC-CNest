using System.Security.Cryptography;
using System.Text;

namespace FSC_CNest.Extensions
{
    public static class StringToHash
    {
        public static byte[] ToHashBytes(this string value, string hash)
        {
            var createdHash = HashAlgorithm.Create(hash);

            var data = CNestSettings.Encoding.GetBytes(value);
            var bytes = createdHash?.ComputeHash(data);

            return bytes ?? new byte[]{ };
        }

        public static string ToHashString(this string value, string hash)
        {
            var createdHash = HashAlgorithm.Create(hash);

            var data = CNestSettings.Encoding.GetBytes(value);
            var bytes = createdHash?.ComputeHash(data);

            var stringBuilder = new StringBuilder();

            for (int i = 0; i < bytes?.Length; i++)
            {
                stringBuilder.Append(bytes[i].ToString("X2"));
            }

            return stringBuilder.ToString();
        }
    }
}
