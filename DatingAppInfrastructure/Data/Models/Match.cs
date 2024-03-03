using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatingAppProject.Infrastructure.Data.Models
{
    public class Match
    {
        [Key]
        public int MatchId { get; set; }

        [ForeignKey("User1Id")]
        public int User1Id { get; set; }

        [ForeignKey("User2Id")]
        public int User2Id { get; set; }

        public User User1 { get; set; } = new User();
        public User User2 { get; set; } = new User();

        public DateTime MatchedAt { get; set; }
    }
}
