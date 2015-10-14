using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace dotNetConfPL.Web.Hubs
{
    [HubName("injectHub")]
    public class InjectHub : Hub
    {
        public void UpdateStream(string newStream, string password)
        {
            //if (PasswordCheck.HashVerified(password))
            //{
                Clients.All.UpdateClient(newStream);
            //}
        }
    }
}
