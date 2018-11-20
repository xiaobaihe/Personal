using Microsoft.EntityFrameworkCore;
using User.API.Models;

namespace User.API.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<AppUsers>()
                .ToTable("Users")
                .HasKey(u => u.Id);
            modelBuilder.Entity<UserProperty>()
                .ToTable("UserProperties")
                .HasKey(u => new { u.Key, u.UserId, u.Value });
            modelBuilder.Entity<UserTag>()
                .ToTable("UserTages")
                .HasKey(t => new { t.UserId, t.Tag });
            modelBuilder.Entity<BPfile>()
                .ToTable("UserBFiles")
                .HasKey(b => b.Id);
            base.OnModelCreating(modelBuilder);

        }
        public DbSet<AppUsers> Users { get; set; }
    }
}
