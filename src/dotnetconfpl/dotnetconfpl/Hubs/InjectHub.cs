using Microsoft.AspNet.SignalR;

namespace dotnetconfpl.Hubs
{
    public class InjectHub : Hub
    {
        public void UpdateStream(string stream)
        {
            Clients.All.UpdateStream(stream);
        }
    }
}