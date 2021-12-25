using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR.Hubs
{
    public class ChatHub:Hub
    {
        public string GetConnectionId()
        {
            return Context.ConnectionId;
        }
        public async Task SendMessageToUser(string sender, string receiver, string message)
        {
            await Clients.Client("connectionId").SendAsync("ReceiveMessage", sender, message);
        }
        public async Task SendMessageToAll(String user,String message)
        {            
            var content = $"{user} 於{DateTime.Now}說：{message}";
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
