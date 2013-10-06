using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNet.SignalR;

namespace dotnetconfpl.Hubs
{
    public class InjectHub : Hub
    {
        public void UpdateStream(string newStream, string password)
        {
            if (this.HashVerified(password))
            {
                Clients.All.UpdateClient(newStream);
            }
        }

        private bool HashVerified(string password)
        {
            var hashedPassword = "38dfaaf2f0381dd1014a8f351e3ae0c7";

            return this.CalculateMd5Hash(password) == hashedPassword.ToUpperInvariant();
        }

        private string CalculateMd5Hash(string input)
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