using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CarSell.Models;

namespace CarSell.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Car> Cars => Set<Car>();
        public DbSet<Purchase> Purchases => Set<Purchase>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Car>()
                .HasOne(c => c.Seller)
                .WithMany()
                .HasForeignKey(c => c.SellerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Purchase>()
                .HasOne(p => p.Buyer)
                .WithMany()
                .HasForeignKey(p => p.BuyerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Purchase>()
                .HasOne(p => p.Car)
                .WithMany()
                .HasForeignKey(p => p.CarId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
