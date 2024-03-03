using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatingAppProject.Infrastructure.Data.Models
{
    public class BlockedUser
    {
        [Key]
        public int BlockId { get; set; }

        [ForeignKey("Blocker")]
        public int BlockerId { get; set; }
        public User Blocker { get; set; } = new User();

        [ForeignKey("UserBlocked")]
        public int UserBlockedId { get; set; }
        public User UserBlocked { get; set; } = new User();

        public DateTime BlockTimestamp { get; set; }
    }
}
