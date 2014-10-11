using System.Security.Cryptography;
using System.Text;

namespace dotnetconfpl
{
    public static class PasswordCheck
    {
        public static bool HashVerified(string password)
        {
            var hashedPassword = "900E11A46495A27370938174CEA7B34B";

            return CalculateMd5Hash(password) == hashedPassword.ToUpperInvariant();
        }

        private static string CalculateMd5Hash(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            var sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}