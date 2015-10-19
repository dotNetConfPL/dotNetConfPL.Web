using Microsoft.AspNet.SignalR;

namespace dotnetconfpl.Hubs
{
    public class InjectHub : Hub
    {
        public void UpdateStream(string newStream, string password, string selectedStream)
        {
            if (newStream.Contains("watch?v="))
            {
                newStream = newStream.Replace("watch?v=", "embed/");
            }

            //if (PasswordCheck.HashVerified(password))
            //{
                var streamInfo = StreamInfo.GetMeStreamInfo(selectedStream);
                Clients.All.UpdateClient(newStream, streamInfo);
            //}
        }
    }
}