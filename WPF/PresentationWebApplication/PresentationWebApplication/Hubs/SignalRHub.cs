using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        public void SendToAll(string name, string message)
        {
            Clients.All.SendAsync(name, message);
        }

        public void SendToSomeUser(string name, string message)
        {
            Clients.Client(Context.ConnectionId).SendAsync(name, message);
        }
        //public void Connect(string userName)
        //{
        //    var id = Context.ConnectionId;


        //    if (Users.All(x => x.Id != int.Parse(id)))
        //    {
        //        Users.Add(new User { Id = int.Parse(id), Email = userName });

        //        // Посылаем сообщение текущему пользователю
        //        Clients.Caller.SendAsync(id, userName, Users);

        //        // Посылаем сообщение всем пользователям, кроме текущего
        //        Clients.AllExcept(id).SendAsync(id, userName);
        //    }
        //}

        //public override Task OnDisconnectedAsync(Exception exception)
        //{
        //    int temporaryId;
        //    int.TryParse(Context.ConnectionId, out temporaryId);
        //    var item = Users.FirstOrDefault(x => x.Id == temporaryId);
        //    if (item != null)
        //    {
        //        Users.Remove(item);
        //        var id = Context.ConnectionId;
        //        Clients.All.SendAsync(id, item.Email);
        //    }
        //    return base.OnDisconnectedAsync(exception);
        //}
    }
}