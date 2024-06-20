using GamingRental.Data.Entities;

namespace GamingRental.Data.Repositories
{
    public class RentalAgreementRepository : BaseRepository<GamingRentalDbContext, RentalAgreement>
    {
        public RentalAgreementRepository(GamingRentalDbContext context) : base(context)
        {
        }
    }
}
