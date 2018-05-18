using System.Security.Cryptography;
using System.Text;

namespace MVCSOLIDDemo.Utils.Helpers.Primitives {
    public static class StringHelper {

        public static string Encrypt(string text) {           

            return "";
        }

        public static string Decrypt(string text) {

            return "";
        }

        private static string ByteHashToString(byte[] byteHash) {

            var sbHashString = new StringBuilder();

            foreach (var b in byteHash)
                sbHashString.Append(b.ToString("x2"));

            return sbHashString.ToString();

        }

        public static string HashMD5(string text) {

            if (string.IsNullOrWhiteSpace(text)) return "";

            var md5 = MD5.Create();
            var byteHash = md5.ComputeHash(Encoding.Default.GetBytes(text));
            
            return ByteHashToString(byteHash);
        }

        public static string HashRIPEMD160(string text) {

            if (string.IsNullOrWhiteSpace(text)) return "";

            var ripemd160 = RIPEMD160.Create();
            var byteHash = ripemd160.ComputeHash(Encoding.Default.GetBytes(text));

            return ByteHashToString(byteHash);
        }

        public static string HashSHA1(string text) {

            if (string.IsNullOrWhiteSpace(text)) return "";

            var sha1 = SHA1.Create();
            var byteHash = sha1.ComputeHash(Encoding.Default.GetBytes(text));

            return ByteHashToString(byteHash);
        }

        public static string HashSHA256(string text) {

            if (string.IsNullOrWhiteSpace(text)) return "";

            var sha256 = SHA256.Create();
            var byteHash = sha256.ComputeHash(Encoding.Default.GetBytes(text));

            return ByteHashToString(byteHash);
        }

        public static string HashSHA384(string text) {

            if (string.IsNullOrWhiteSpace(text)) return "";

            var sha384 = SHA384.Create();
            var byteHash = sha384.ComputeHash(Encoding.Default.GetBytes(text));

            return ByteHashToString(byteHash); 
        }

        public static string HashSHA512(string text) {

            if (string.IsNullOrWhiteSpace(text)) return "";

            var sha512 = SHA512.Create();
            var byteHash = sha512.ComputeHash(Encoding.Default.GetBytes(text));

            return ByteHashToString(byteHash);
        }

    }
}
