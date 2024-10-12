using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Billing_System
{
    public static class SecurityFunctions
    {
        // Ensure that the key is 32 bytes long for AES-256 by decoding the Base64 string
        private static readonly byte[] Key = Convert.FromBase64String("jN0WJ3kTeJIs2F3sajh6h4u+ZlSDbV9Ho1Y/qBjJDm4=");

        // Encrypt password
        public static string EncryptPassword(string plainText)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Key;

                // Generate a new random IV for each encryption
                aes.GenerateIV();
                byte[] iv = aes.IV;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream())
                {
                    // Prepend the IV to the encrypted data
                    ms.Write(iv, 0, iv.Length);

                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(plainText);
                        }
                    }

                    // Return IV + ciphertext as Base64 string
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        // Decrypt password
        public static string DecryptPassword(string cipherText)
        {
            byte[] fullCipher = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Key;

                // Extract the IV from the beginning of the cipherText
                byte[] iv = new byte[aes.BlockSize / 8]; // AES block size is 128 bits (16 bytes)
                byte[] cipherBytes = new byte[fullCipher.Length - iv.Length];

                Array.Copy(fullCipher, 0, iv, 0, iv.Length);
                Array.Copy(fullCipher, iv.Length, cipherBytes, 0, cipherBytes.Length);

                aes.IV = iv;

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream(cipherBytes))
                {
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader sr = new StreamReader(cs))
                        {
                            return sr.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}
