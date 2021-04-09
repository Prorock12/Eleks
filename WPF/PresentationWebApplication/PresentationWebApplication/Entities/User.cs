using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PresentationWebApplication.Entities
{
    public class User
    {
        [Key] 
        public string Id { get; set; }

        [MinLength(6)]
        public string Email { get; set; }

        [PasswordPropertyText]
        public string Password { get; set; }

        public User(string email,string password) : this()
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