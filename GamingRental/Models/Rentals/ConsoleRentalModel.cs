using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace GamingRental.Models.Rentals
{
    public class ConsoleRentalModel : PageModel
    {
        [ProtectedPersonalData]
        [Required(ErrorMessage = "Alege tipul de consola")]
        public Guid ConsoleTypeId { get; set; }

        [Required(ErrorMessage = "Introdu data de inceput pentru inchiriere")]
        [DataType(DataType.DateTime)]
        [Display(Name = "RentalStartDate")]
        public DateTime RentalStartDate { get; set; }

        [Required(ErrorMessage = "Introdu data de sfarsit pentru inchiriere")]
        [Display(Name = "RentalEndDate")]
        public DateTime RentalEndDate { get; set; }
    }
}