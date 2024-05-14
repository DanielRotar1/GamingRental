using LicentaTest.Data.Entities;

namespace LicentaTest.Data.Repositories
{
    public class CarTypeRepository : BaseRepository<LicentaTestDbContext, CarType>
    {
        public CarTypeRepository(LicentaTestDbContext context) : base(context)
        {
        }
    }
}
