using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.ChatModel
{
    public class User
    {
        public string Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }
        public User()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
