using GamingRental.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GamingRental.Data
{
    public class GamingRentalDbContext : IdentityDbContext
    {
        public GamingRentalDbContext(DbContextOptions<GamingRentalDbContext> options)
            : base(options)
        {
        }

        public DbSet<RentalAgreement> RentalAgreements { get; set; }

        public DbSet<ConsoleType> ConsoleTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<RentalAgreement>()
                .HasOne(a => a.ConsoleType);

            builder.Entity<ConsoleType>()
                .HasKey(a => a.Id);
        }
    }
}
