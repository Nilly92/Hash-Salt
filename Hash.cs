using System.Text;
using System.Security.Cryptography;

namespace Pswd
{
    class Hash
    {
        public static string HashString(string passwordString,string salt)
        {
            byte[] hash_bytes;
            using (HashAlgorithm algorithm = SHA256.Create())
            {
                hash_bytes = algorithm.ComputeHash(Encoding.UTF8.GetBytes(passwordString + salt + "key"));
            }
            StringBuilder sb = new StringBuilder();
            foreach (byte b in hash_bytes)
            {
                sb.Append(b.ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
