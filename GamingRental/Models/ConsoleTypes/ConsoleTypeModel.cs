using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace GamingRental.Models.ConsoleTypes
{
    public class ConsoleTypeModel : PageModel
    {
        public string ConsoleTypeId { get; set; }

        [Required(ErrorMessage = "Te rog alege o descriere")]
        public string? Description { get; set; }
    }
}
