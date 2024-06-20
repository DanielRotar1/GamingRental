using LicentaTest.Data.Entities;

namespace LicentaTest.Data.Repositories
{
    public class ConsoleTypeRepository : BaseRepository<LicentaTestDbContext, ConsoleType>
    {
        public ConsoleTypeRepository(LicentaTestDbContext context) : base(context)
        {
        }
    }
}
