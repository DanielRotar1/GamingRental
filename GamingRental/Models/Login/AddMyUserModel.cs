using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace GamingRental.Models.Login
{
    public class LoginUserModel : PageModel
    {
        [ProtectedPersonalData]
        [Required(ErrorMessage = "Te rog sa iti alegi un nume")]
        public string? UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Parola trebuie sa fie macar {2} si maximum {1} caractere.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
