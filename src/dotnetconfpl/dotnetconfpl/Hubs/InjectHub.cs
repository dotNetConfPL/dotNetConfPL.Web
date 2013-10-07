using Microsoft.AspNet.SignalR;

namespace dotnetconfpl.Hubs
{
    public class InjectHub : Hub
    {
        public void UpdateStream(string newStream, string password)
        {
            if (PasswordCheck.HashVerified(password))
            {
                Clients.All.UpdateClient(newStream);
            }
        }

    }
}