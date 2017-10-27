using ChatProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;

namespace ChatProject.Controllers
{
    public class ChatsController : ApiController
    {
        private ChatEntities db;

        public ChatsController()
        {
            db = new ChatEntities();
        }

        // GET api/<controller>
        public List<Msg> Get()
        {
            List<Msg> list = new List<Msg>();
            db.Messages.OrderBy(w => w.Time).Include(w => w.User).ToList().ForEach(w=> list.Add(new Msg(w.User.Email,w.Time.ToShortTimeString(),w.Content)));
            return list;
        }

        
    }
}