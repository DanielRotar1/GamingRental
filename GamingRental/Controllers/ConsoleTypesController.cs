using GamingRental.Data.Entities;
using GamingRental.Data.Repositories;
using GamingRental.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GamingRental.Controllers
{
    public class ConsoleTypesController : Controller
    {
        private readonly IRepository<ConsoleType> _repository;

        public ConsoleTypesController(IRepository<ConsoleType> repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> AddConsoleType(IFormCollection collection)
        {
            try
            {
                var consoleType = new ConsoleType() { Description = collection["Description"] };
                _repository.Add(consoleType);
                await _repository.Save();

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }

        public async Task<ActionResult> DeleteConsoleType(IFormCollection collection)
        {
            try
            {
                var id = Guid.Parse(collection["ConsoleTypeId"]);
                var consoleType = _repository.FindBy(x => x.Id == id).FirstOrDefault();
                if (consoleType != null)
                {
                    _repository.Delete(consoleType);
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
