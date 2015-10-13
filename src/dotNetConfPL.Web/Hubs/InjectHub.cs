using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace dotNetConfPL.Web.Hubs
{
    [HubName("injectHub")]
    public class InjectHub : Hub
    {
        public void UpdateStream(string newStream, string password, string selectedStream)
        {
            if (PasswordCheck.HashVerified(password))
            {
                //var streamInfo = StreamInfo.GetMeStreamInfo(selectedStream);
                //Clients.All.UpdateClient(newStream, streamInfo);
            }
        }
    }
}
