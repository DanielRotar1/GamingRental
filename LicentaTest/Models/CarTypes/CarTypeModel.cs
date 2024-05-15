using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace LicentaTest.Models.CarTypes
{
    public class CarTypeModel : PageModel
    {
        public string CarTypeId { get; set; }

        [Required(ErrorMessage = "Please choose a description")]
        public string? Description { get; set; }
    }
}
