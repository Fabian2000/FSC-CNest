using FSC_CNest.Extensions;
using System;
using System.IO;
using System.Security.Cryptography;

namespace FSC_CNest.Crypt
{
    /// <summary>
    /// Encrypt and decrypt files or text with AES256
    /// </summary>
    public class AES
    {
        private Aes? _aesCrypto = Aes.Create();

        /// <summary>
        /// Creates an AES instance
        /// </summary>
        /// <param name="key">Password</param>
        /// <param name="iv">IV</param>
        /// <param name="cipherMode"></param>
        /// <param name="paddingMode"></param>
        public AES(string key, string iv, CipherMode cipherMode = CipherMode.CBC, PaddingMode paddingMode = PaddingMode.PKCS7) => Init(key.ToHashBytes("SHA256"), iv.ToHashBytes("MD5"), cipherMode, paddingMode);

        /// <summary>
        /// Creates an AES instance
        /// </summary>
        /// <param name="key">Password</param>
        /// <param name="iv">IV</param>
        /// <param name="cipherMode"></param>
        /// <param name="paddingMode"></param>
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

        /// <summary>
        /// Encrypts a string
        /// </summary>
        /// <param name="text">String for the encryption</param>
        /// <returns>Returns the encrypted string as bytes or base64 >> (string)</returns>
        public (byte[] Bytes, string Base64) Encrypt(string text)
        {
            var transform = _aesCrypto?.CreateEncryptor();

            byte[] encryptedBytes = transform?.TransformFinalBlock(CNestSettings.Encoding.GetBytes(text), 0, text.Length) ?? new byte[] {};

            string base64 = Convert.ToBase64String(encryptedBytes);

            return (encryptedBytes, base64);
        }

        /// <summary>
        /// Uses the Encrypt(...) method and write the content into a file
        /// </summary>
        /// <param name="path">Path for the file</param>
        /// <param name="content">content to write</param>
        public void WriteFile(string path, string content)
        {
            File.WriteAllBytes(path, Encrypt(content).Bytes);
        }

        /// <summary>
        /// Decrypts a base64 string
        /// </summary>
        /// <param name="text">base64 string</param>
        /// <returns>Returns the decrypted data as string</returns>
        public string Decrypt(string text)
        {
            var transform = _aesCrypto?.CreateDecryptor();

            byte[] encBytes = Convert.FromBase64String(text);
            byte[] decryptedBytes = transform?.TransformFinalBlock(encBytes, 0, encBytes.Length) ?? new byte[] {};

            string str = CNestSettings.Encoding.GetString(decryptedBytes);

            return str;
        }

        /// <summary>
        /// Decrypts a byte array
        /// </summary>
        /// <param name="text">byte array</param>
        /// <returns>Returns the decrypted data as string</returns>
        public string Decrypt(byte[] text)
        {
            var transform = _aesCrypto?.CreateDecryptor();

            byte[] encBytes = text;
            byte[] decryptedBytes = transform?.TransformFinalBlock(encBytes, 0, encBytes.Length) ?? new byte[] {};

            string str = CNestSettings.Encoding.GetString(decryptedBytes);

            return str;
        }

        /// <summary>
        /// Uses the Decrypt(...) method and reads the content from a file
        /// </summary>
        /// <param name="path">Path for the file</param>
        /// <returns>Returns the decrypted data as string</returns>
        public string ReadFile(string path)
        {
            return Decrypt(File.ReadAllBytes(path));
        }
    }
}
