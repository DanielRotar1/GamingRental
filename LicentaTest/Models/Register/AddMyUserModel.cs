using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace LicentaTest.Models.Register
{
    public class AddMyUserModel : PageModel
    {
        [ProtectedPersonalData]
        [Required(ErrorMessage = "Te rog alege un nume")]
        public string? UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Parola trebuie sa fie macar {2} si maximum {1} caractere.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Parola")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirma parola")]
        [Compare("Password", ErrorMessage = "Parolele introduse nu sunt identice, incearca din nou.")]
        public string ConfirmPassword { get; set; }
    }
}
