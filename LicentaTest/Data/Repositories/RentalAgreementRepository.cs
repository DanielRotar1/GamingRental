using LicentaTest.Data.Entities;

namespace LicentaTest.Data.Repositories
{
    public class RentalAgreementRepository : BaseRepository<LicentaTestDbContext, RentalAgreement>
    {
        public RentalAgreementRepository(LicentaTestDbContext context) : base(context)
        {
        }
    }
}
