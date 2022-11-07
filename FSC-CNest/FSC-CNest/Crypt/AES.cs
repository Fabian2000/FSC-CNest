using FSC_CNest.Extensions;
using System.Security.Cryptography;

namespace FSC_CNest.Crypt
{
    public class AES
    {
        private Aes? _aesCrypto = Aes.Create();

        public AES(string key, string iv, CipherMode cipherMode = CipherMode.CBC, PaddingMode paddingMode = PaddingMode.PKCS7) => Init(key.ToHashBytes("SHA256"), iv.ToHashBytes("MD5"), cipherMode, paddingMode);

        public AES(byte[] key, byte[] iv, CipherMode cipherMode = CipherMode.CBC, PaddingMode paddingMode = PaddingMode.PKCS7) => Init(key, iv, cipherMode, paddingMode);

        private void Init(byte[] key, byte[] iv, CipherMode cipherMode = CipherMode.CBC, PaddingMode paddingMode = PaddingMode.PKCS7)
        {
            _aesCrypto = Aes.Create();
            _aesCrypto.BlockSize = 128;
            _aesCrypto.KeySize = 256;
            _aesCrypto.Key = key;
            _aesCrypto.IV = iv;
            _aesCrypto.Mode = cipherMode;
            _aesCrypto.Padding = paddingMode;
        }

        public (byte[] Bytes, string Base64) Encrypt(string text)
        {
            var transform = _aesCrypto?.CreateEncryptor();

            byte[] encryptedBytes = transform?.TransformFinalBlock(CNestSettings.Encoding.GetBytes(text), 0, text.Length) ?? new byte[] {};

            string base64 = Convert.ToBase64String(encryptedBytes);

            return (encryptedBytes, base64);
        }

        public string Decrypt(string text)
        {
            var transform = _aesCrypto?.CreateDecryptor();

            byte[] encBytes = Convert.FromBase64String(text);
            byte[] decryptedBytes = transform?.TransformFinalBlock(encBytes, 0, encBytes.Length) ?? new byte[] {};

            string str = CNestSettings.Encoding.GetString(decryptedBytes);

            return str;
        }

        public string Decrypt(byte[] text)
        {
            var transform = _aesCrypto?.CreateDecryptor();

            byte[] encBytes = text;
            byte[] decryptedBytes = transform?.TransformFinalBlock(encBytes, 0, encBytes.Length) ?? new byte[] {};

            string str = CNestSettings.Encoding.GetString(decryptedBytes);

            return str;
        }
    }
}
