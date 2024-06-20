using GamingRental.Data.Entities;
using GamingRental.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using System.Diagnostics;
using System.Text.Encodings.Web;
using System.Text;
using GamingRental.Data.Seeding;

namespace GamingRental.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public RegisterController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> Register(IFormCollection collection)
        {
            try
            {
                var user = new AddUserIdentity(collection["UserName"], collection["UserName"]);
                var result = await _userManager.CreateAsync(user);
                var parola = await _userManager.AddPasswordAsync(user, collection["Password"]);
                await _userManager.AddToRoleAsync(user, Role.Client);
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                await _userManager.ConfirmEmailAsync(user, code);
                await _userManager.SetLockoutEnabledAsync(user, false);

                return RedirectToAction("Index", "Login");
            }
            catch
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }
    }
}
