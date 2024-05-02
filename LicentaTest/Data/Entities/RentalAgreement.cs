using LicentaTest.Data.Entities.Common;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace LicentaTest.Data.Entities
{
    public class RentalAgreement : TrackedModelBase
    {
        public virtual AddUserIdentity User { get; set; }

        public string UserId { get; set; }

        public string CarType { get; set; }

        public DateTime RentalStartDate { get; set; }

        public DateTime RentalEndDate { get; set; }

        public RentalAgreement() { }
    }
}
