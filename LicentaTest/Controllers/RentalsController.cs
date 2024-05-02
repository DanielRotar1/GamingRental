using LicentaTest.Data.Entities;
using LicentaTest.Data.Repositories;
using LicentaTest.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LicentaTest.Controllers
{
    public class RentalsController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IRepository<RentalAgreement> _repository;

        public RentalsController(UserManager<IdentityUser> userManager, IRepository<RentalAgreement> repository)
        {
            _userManager = userManager;
            _repository = repository;
        }

        public ActionResult Index()
        {
            var rentals = _repository.GetAll().Where(x => x.UserId == _userManager.GetUserId(this.User));
            
            //if (rentals.Any())
            //{
            //    View("RentalList", rentals);
            //}

            return View();
        }

        public async Task<ActionResult> RentCar(IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var rentalAgreement = new RentalAgreement()
                    {
                        CarType = collection["CarType"],
                        RentalStartDate = DateTime.Parse(collection["RentalStartDate"]),
                        RentalEndDate = DateTime.Parse(collection["RentalEndDate"]),
                        UserId = _userManager.GetUserId(this.User)
                    };

                    _repository.Add(rentalAgreement);
                    await _repository.Save();
                }

                return RedirectToAction("Index", "Rentals");
            }
            catch
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }
    }
}
