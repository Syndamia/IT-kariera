using Microsoft.EntityFrameworkCore;
using PandaWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace PandaWebApp.Data
{
    public class PandaDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Package> Packages { get; set; }

        public DbSet<Receipt> Receipts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Server=localhost;Port=5432;Database=PANDA;User Id=kamen;Password=password;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Receipt>()
                .HasOne(u => u.Recipient)
                .WithMany(u => u.Receipts)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Receipt>()
                .HasOne(u => u.Package)
                .WithMany(u => u.Receipts)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Package>()
                .HasOne(u => u.Recipient)
                .WithMany(u => u.Packages)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
