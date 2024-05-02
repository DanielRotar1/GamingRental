using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace LicentaTest.Models.Rentals
{
    public class CarRentalModel : PageModel
    {
        [ProtectedPersonalData]
        [Required(ErrorMessage = "Pune tip masina")]
        public string? CarType { get; set; }

        [Required(ErrorMessage = "pune data inceput")]
        [DataType(DataType.DateTime)]
        [Display(Name = "RentalStartDate")]
        public DateTime RentalStartDate { get; set; }

        [Required(ErrorMessage = "pune data sfarsit")]
        [Display(Name = "RentalEndDate")]
        public DateTime RentalEndDate { get; set; }
    }
}