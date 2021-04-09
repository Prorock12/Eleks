using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace PresentationWebApplication.Entities
{
    public class Message
    {
        [Key] 
        public string Id { get; set; }
        public string SenderId { get; set; }
        public string ReceiverId { get; set; }
        [Required] 
        public string Text { get; set; }

        public Message(string senderId, string receiverId,string text) : base()
        {
            SenderId = senderId;
            ReceiverId = receiverId;
            Text = text;
        }
        public Message()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}