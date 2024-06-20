using GamingRental.Data.Entities;

namespace GamingRental.Data.Repositories
{
    public class ConsoleTypeRepository : BaseRepository<GamingRentalDbContext, ConsoleType>
    {
        public ConsoleTypeRepository(GamingRentalDbContext context) : base(context)
        {
        }
    }
}
