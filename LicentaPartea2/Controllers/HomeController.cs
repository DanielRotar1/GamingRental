using LicentaPartea2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LicentaPartea2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Produse()
        {
            return View();
        }
        public IActionResult Despre()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Inregistrare()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
