using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace MVCSOLIDDemo.Utils.Helpers.Primitives {

    public static class StringHelper {

        private static string ByteHashToCipherText(byte[] byteHash) {

            var sbCypherText = new StringBuilder();

            foreach (var b in byteHash)
                sbCypherText.Append(b.ToString("x2"));

            return sbCypherText.ToString();

        }

        private static byte [] CipherTextToByteHash(string cipherText) {
                        
            return Encoding.ASCII.GetBytes(cipherText);

        }

        public static string EncryptAES(string plainText, byte[] Key, byte[] IV) {           
                    
            //Check arguments.
            if (plainText == null || plainText.Length <= 0) throw new ArgumentNullException("plainText");
            
            if (Key == null || Key.Length <= 0) throw new ArgumentNullException("Key");
            
            if (IV == null || IV.Length <= 0) throw new ArgumentNullException("IV");
            
            byte[] encrypted;
            
            //Create an Aes object with the specified key and IV.
            using (Aes aesAlg = Aes.Create()) {

                aesAlg.Key = Key;

                aesAlg.IV = IV;

                //Create a decrytor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                //Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream()) {

                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt , encryptor, CryptoStreamMode.Write)) {
                    
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt)) {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }


            // Return the encrypted bytes from the memory stream.
            return ByteHashToCipherText(encrypted);

       }

        public static string DecryptAES(string cipherText, byte[] Key, byte[] IV) {

            var chyherByteArray = CipherTextToByteHash(cipherText);

            //Check arguments.
            if (chyherByteArray == null || chyherByteArray.Length <= 0) throw new ArgumentNullException("cipherText");
            
            if (Key == null || Key.Length <= 0) throw new ArgumentNullException("Key");
            
            if (IV == null || IV.Length <= 0) throw new ArgumentNullException("IV");

            //Declare the string used to hold the decrypted text.
            string plainText = null;

            //Create an Aes object with the specified key and IV.
            using (Aes aesAlg = Aes.Create()) {

                aesAlg.Key = Key;
                aesAlg.IV = IV;

                //Create a decrytor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                //Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(chyherByteArray)) {

                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read)) {
                        
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt)) {

                            // Read the decrypted bytes from the decrypting stream and place them in a string.
                            plainText = srDecrypt.ReadToEnd();
                        }
                    }
                }

            }


            return plainText;
        }
       
        public static string HashMD5(string plainText) {

            if (string.IsNullOrWhiteSpace(plainText)) return "";

            var md5 = MD5.Create();
            var byteHash = md5.ComputeHash(Encoding.Default.GetBytes(plainText));
            
            return ByteHashToCipherText(byteHash);
        }

        public static string HashRIPEMD160(string plainText) {

            if (string.IsNullOrWhiteSpace(plainText)) return "";

            var ripemd160 = RIPEMD160.Create();
            var byteHash = ripemd160.ComputeHash(Encoding.Default.GetBytes(plainText));

            return ByteHashToCipherText(byteHash);
        }

        public static string HashSHA1(string plainText) {

            if (string.IsNullOrWhiteSpace(plainText)) return "";

            var sha1 = SHA1.Create();
            var byteHash = sha1.ComputeHash(Encoding.Default.GetBytes(plainText));

            return ByteHashToCipherText(byteHash);
        }

        public static string HashSHA256(string plainText) {

            if (string.IsNullOrWhiteSpace(plainText)) return "";

            var sha256 = SHA256.Create();
            var byteHash = sha256.ComputeHash(Encoding.Default.GetBytes(plainText));

            return ByteHashToCipherText(byteHash);
        }

        public static string HashSHA384(string plainText) {

            if (string.IsNullOrWhiteSpace(plainText)) return "";

            var sha384 = SHA384.Create();
            var byteHash = sha384.ComputeHash(Encoding.Default.GetBytes(plainText));

            return ByteHashToCipherText(byteHash); 
        }

        public static string HashSHA512(string plainText) {

            if (string.IsNullOrWhiteSpace(plainText)) return "";

            var sha512 = SHA512.Create();
            var byteHash = sha512.ComputeHash(Encoding.Default.GetBytes(plainText));

            return ByteHashToCipherText(byteHash);
        }

    }

}
