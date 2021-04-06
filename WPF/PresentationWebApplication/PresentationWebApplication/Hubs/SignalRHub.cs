using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace PresentationWebApplication.Hubs
{
    public class SignalRHub : Hub
    {
        public HashSet<object> Messages { get; set; }

        public SignalRHub()
        {
            Messages = new HashSet<object>();
        }
        private async Task JoinGroup(string groupName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
        }
        [HubMethodName("name")]
        public async Task JoinGroup()
        {
            await JoinGroup("name");
        }

    }
}