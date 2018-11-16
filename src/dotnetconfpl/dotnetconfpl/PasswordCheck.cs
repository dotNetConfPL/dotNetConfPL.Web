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
            var hashedPassword = "494B3B00BEDE6D70A1813B2E64DC2D8F002AA6F26EC936D124668EBCA78E5AFA";
            return CalculateSha256Hash(password) == hashedPassword.ToUpperInvariant();
        }

        public static string CalculateSha256Hash(string input)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hash = sha256.ComputeHash(inputBytes);

            var sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}