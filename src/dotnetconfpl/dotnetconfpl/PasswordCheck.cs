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
            var hashedPassword = "1C23BDC3B1078E34F314BBB06E7CAF04566A824EA3D550F41ED728D04E7D3480";
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