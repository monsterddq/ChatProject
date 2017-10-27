using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;
using ChatProject.Models;


namespace ChatProject.Hubs
{
    public class ChatHub : Hub
    {
        private ChatEntities db;
        private ApplicationDbContext dbUser;

        public ChatHub()
        {
            db = new ChatEntities();
            dbUser = new ApplicationDbContext();
        }

        public override Task OnConnected()
        {
            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            return base.OnDisconnected(stopCalled);
        }

        public void Message(string message, string userid)
        {
            Message msg = new Models.Message
            {
                Content = message,
                Time = DateTime.Now,
                UserId = userid
            };
            var q = dbUser.Users.Find(userid);
            db.Messages.Add(msg);
            db.SaveChanges();
            Clients.All.sendMessage(message, msg.Time.ToShortTimeString(), q.UserName);
        }
    }
}