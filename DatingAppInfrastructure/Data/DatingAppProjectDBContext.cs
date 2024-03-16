using DatingAppProject.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DatingAppProject.Infrastructure.Data
{
    public class DatingAppProjectDBContext : IdentityDbContext
    {
        public DatingAppProjectDBContext(DbContextOptions<DatingAppProjectDBContext> options)
            : base(options)
        {
        }

        public DbSet<User> AppUsers { get; set; } = null!;
        public DbSet<Interest> Interests { get; set; } = null!;
        public DbSet<UserInterest> UserInterests { get; set; } = null!;
        public DbSet<Match> Matches { get; set; } = null!; 
        public DbSet<Message> Messages { get; set; } = null!;
        public DbSet<Photo> Photos { get; set; } = null!;
        public DbSet<BlockedUser> BlockedUsers { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserInterest>()
                .HasKey(ui => new { ui.UserId, ui.InterestId });

            modelBuilder.Entity<UserInterest>()
                .HasOne(ui => ui.User)
                .WithMany(u => u.UserInterests)
                .HasForeignKey(ui => ui.UserId);

            modelBuilder.Entity<UserInterest>()
                .HasOne(ui => ui.Interest)
                .WithMany(i => i.UserInterests) 
                .HasForeignKey(ui => ui.InterestId);

            modelBuilder.Entity<Match>()
                .HasOne(m => m.User1)
                .WithMany(u => u.User1Matches) 
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Match>()
                .HasOne(m => m.User2)
                .WithMany(u => u.User2Matches) 
                .HasForeignKey(m => m.User2Id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.Sender)
                .WithMany(u => u.SentMessages)
                .HasForeignKey(m => m.SenderId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.Receiver)
                .WithMany(u => u.ReceivedMessages)
                .HasForeignKey(m => m.ReceiverId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Photo>()
                .HasOne(p => p.User)
                .WithMany(u => u.Photos)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<BlockedUser>()
                .HasOne(b => b.Blocker) 
                .WithMany(b => b.BlockerUsers)
                .HasForeignKey(b => b.BlockerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<BlockedUser>()
                .HasOne(b => b.UserBlocked) 
                .WithMany(b => b.BlockedUsers)
                .HasForeignKey(b => b.UserBlockedId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }
}
