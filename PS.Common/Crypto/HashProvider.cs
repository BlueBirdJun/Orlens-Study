using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace PS.Common.Crypto
{
    public class HashProvider
    {
        public static string SHA256Hash(string data)
        {
            if (string.IsNullOrEmpty(data)) return "";

            SHA256 sha = new SHA256Managed();
            var hash = sha
                .ComputeHash(Encoding.UTF8.GetBytes(data))
                .Select(s => s.ToString("x2"));

            return string.Join("", hash);
        }

        public static string Md5Hash(string data)
        {
            if (string.IsNullOrEmpty(data)) return "";

            var md5 = MD5.Create();
            var hash = md5
                .ComputeHash(Encoding.UTF8.GetBytes(data))
                .Select(s => s.ToString("x2"));

            return string.Join("", hash);
        }
    }
}
