using LicentaTest.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LicentaTest.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public LoginController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> Login(IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var userIdentity = await _userManager.FindByEmailAsync(collection["UserName"]);

                    if (userIdentity != null)
                    {
                        var result = await _signInManager.PasswordSignInAsync(userIdentity, collection["Password"], isPersistent: false, false);
                        if (result.Succeeded)
                        {
                            return RedirectToAction("Index", "Home");
                        }
                    }
                }

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }
    }
}
