using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatingAppProject.Infrastructure.Data.Models
{
    public class Photo
    {
        [Key]
        public int PhotoId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; } = new User();

        public string PhotoUrl { get; set; } = string.Empty;
    }
}
