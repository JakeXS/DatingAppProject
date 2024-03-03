using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatingAppProject.Infrastructure.Data.Models
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }

        [ForeignKey("Sender")]
        public int SenderId { get; set; }
        public User Sender { get; set; } = new User();

        [ForeignKey("Receiver")]
        public int ReceiverId { get; set; }
        public User Receiver { get; set; } = new User();

        public string MessageContent { get; set; } = string.Empty;

        public DateTime Timestamp { get; set; }
    }
}
