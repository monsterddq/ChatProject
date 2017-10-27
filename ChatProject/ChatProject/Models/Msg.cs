using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatProject.Models
{
    public class Msg
    {
        public Msg(string email, string time, string content)
        {
            Email = email;
            Time = time;
            Content = content;
        }

        public Msg()
        {
        }

        public string Email { get; set; }
        public string Time { get; set; }
        public string Content { get; set; }
    }
}