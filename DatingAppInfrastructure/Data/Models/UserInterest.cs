using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatingAppProject.Infrastructure.Data.Models
{
    public class UserInterest
    {
        [Key]
        public int UserInterestId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; } = new User();

        [ForeignKey("Interest")]
        public int InterestId { get; set; }
        public Interest Interest { get; set; } = new Interest();
    }
}
