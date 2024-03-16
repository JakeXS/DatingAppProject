using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using static DatingAppProject.Infrastructure.Constants.DataConstants;

namespace DatingAppProject.Infrastructure.Data.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(MaxNameLength)]
        public string Username { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;

        [Required]
        public DateTime? DateOfBirth { get; set; }

        [Required]
        public string Gender { get; set; } = string.Empty;

        [Required]
        public string Location { get; set; } = string.Empty;

        [MaxLength(MaxBioLength)]
        public string Biography { get; set; } = string.Empty;

        public string PictureURL { get; set; } = string.Empty;

        public DateTime? LastLogIn { get; set; }


        public ICollection<UserInterest> UserInterests { get; set; } = new List<UserInterest>();
        public ICollection<Match> User1Matches { get; set; } = new List<Match>();
        public ICollection<Match> User2Matches { get; set; } = new List<Match>();
        public ICollection<Message> SentMessages { get; set; } = new List<Message>();
        public ICollection<Message> ReceivedMessages { get; set; } = new List<Message>();
        public ICollection<Photo> Photos { get; set; } = new List<Photo>();
        public ICollection<BlockedUser> BlockedUsers { get; set; } = new List<BlockedUser>();
        public ICollection<BlockedUser> BlockerUsers { get; set; } = new List<BlockedUser>();
    }
}

