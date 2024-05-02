using LicentaTest.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LicentaTest.Data
{
    public class LicentaTestDbContext : IdentityDbContext
    {
        public LicentaTestDbContext(DbContextOptions<LicentaTestDbContext> options)
            : base(options)
        {
        }

        public DbSet<RentalAgreement> RentalAgreements { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<RentalAgreement>()
                .HasKey(a => a.Id);
        }
    }
}
