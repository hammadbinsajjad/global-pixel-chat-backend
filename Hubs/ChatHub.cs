using Microsoft.AspNetCore.SignalR;

namespace Backend.Hubs;

public class ChatHub: Hub
{
    public async Task SendMessage(string user, string message, string color)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, message, color);
    }
}