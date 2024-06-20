using LicentaTest.Data.Entities.Common;

namespace LicentaTest.Data.Entities
{
    public class RentalAgreement : TrackedModelBase
    {
        public virtual AddUserIdentity User { get; set; }

        public string UserId { get; set; }

        public virtual ConsoleType ConsoleType { get; set; }

        public Guid ConsoleTypeId { get; set; }

        public DateTime RentalStartDate { get; set; }

        public DateTime RentalEndDate { get; set; }

        public RentalAgreement() { }
    }
}
