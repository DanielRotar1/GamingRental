using GamingRental.Data.Entities;
using GamingRental.Data.Repositories;
using GamingRental.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GamingRental.Controllers
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
            var rentals = _repository.FindBy(x => x.UserId == _userManager.GetUserId(this.User), x => x.ConsoleType).ToList();
            return View(rentals);
        }

        public ActionResult AddNewRental()
        {
            return View();
        }

        public async Task<ActionResult> RentConsole(IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var rentalAgreement = new RentalAgreement()
                    {
                        ConsoleTypeId = Guid.Parse(collection["ConsoleTypeId"]),
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

        public async Task<ActionResult> DeleteRental(IFormCollection collection)
        {
            try
            {
                var id = Guid.Parse(collection["RentalId"]);
                var rentalAgreement = _repository.FindBy(x => x.Id == id).FirstOrDefault();
                if (rentalAgreement != null)
                {
                    _repository.Delete(rentalAgreement);
                }

                await _repository.Save();

                return RedirectToAction("Index", "Rentals");
            }
            catch
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }
    }
}
