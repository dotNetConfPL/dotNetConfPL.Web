using System.Security.Cryptography;
using System.Text;

namespace dotnetconfpl
{
    public static class PasswordCheck
    {
        public static bool HashVerified(string password)
        {
            // Odziedziczione, nadpisane
            //var hashedPassword = "22F36417CBB2228C9581E2E73F98F4CE";
            var hashedPassword = "FEA003D5F02931FA38B943A4D0FF85F7";
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