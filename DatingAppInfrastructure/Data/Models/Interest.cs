using System.ComponentModel.DataAnnotations;

namespace DatingAppProject.Infrastructure.Data.Models
{
    public class Interest
    {
        [Key]
        public int InterestId { get; set; }

        [Required]
        public string InterestName { get; set;} = string.Empty;

        public ICollection<UserInterest> UserInterests { get; set; } = new List<UserInterest>();
    }
}
