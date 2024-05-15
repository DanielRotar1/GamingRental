using LicentaTest.Data.Entities.Common;

namespace LicentaTest.Data.Entities
{
    public class RentalAgreement : TrackedModelBase
    {
        public virtual AddUserIdentity User { get; set; }

        public string UserId { get; set; }

        public virtual CarType CarType { get; set; }

        public Guid CarTypeId { get; set; }

        public DateTime RentalStartDate { get; set; }

        public DateTime RentalEndDate { get; set; }

        public RentalAgreement() { }
    }
}
