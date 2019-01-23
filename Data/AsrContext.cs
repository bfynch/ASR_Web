using Asr.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Asr.Data
{
    public class AsrContext : IdentityDbContext<ApplicationUser>
    {
        public AsrContext(DbContextOptions<AsrContext> options) : base(options)
        { }

        public DbSet<Room> Room { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Slot> Slot { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Slot>().HasKey(x => new { x.RoomID, x.StartTime });
        }
    }
}
