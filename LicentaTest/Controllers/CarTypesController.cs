using LicentaTest.Data.Entities;
using LicentaTest.Data.Repositories;
using LicentaTest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LicentaTest.Controllers
{
    public class CarTypesController : Controller
    {
        private readonly IRepository<CarType> _repository;

        public CarTypesController(IRepository<CarType> repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> AddCarType(IFormCollection collection)
        {
            try
            {
                var carType = new CarType() { Description = collection["Description"] };
                _repository.Add(carType);
                await _repository.Save();

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }

        public async Task<ActionResult> DeleteCarType(IFormCollection collection)
        {
            try
            {
                var id = Guid.Parse(collection["CarTypeId"]);
                var carType = _repository.FindBy(x => x.Id == id).FirstOrDefault();
                if (carType != null)
                {
                    _repository.Delete(carType);
                }

                await _repository.Save();

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }
    }
}
