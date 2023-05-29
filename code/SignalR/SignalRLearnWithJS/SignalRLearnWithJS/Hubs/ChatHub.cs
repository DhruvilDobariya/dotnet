using Microsoft.AspNetCore.SignalR;

namespace SignalRLearnWithJS.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string password)
        {
            await Clients.All.SendAsync( "ReceivedMessage", user, password);
        }
    }
}
