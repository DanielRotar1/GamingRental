using LicentaTest.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LicentaTest.Controllers
{
    public class InregistrareController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        public InregistrareController( UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }
        // GET: Inregistrare
        public ActionResult Index()
        {
            return View();
        }

        // GET: Inregistrare/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Inregistrare/Create``
        
        public ActionResult Create() 
        {
            return View();
        }

        // POST: Inregistrare/Create
        [HttpPost]
        
        public async Task <ActionResult> Create(IFormCollection collection)
        {
            try
            {
                var user = new AddMyUser(collection["Nume"], collection["Email"], collection["Parola"]);
                var result = await _userManager.CreateAsync(user);
                
                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return View();
            }
        }

        // GET: Inregistrare/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Inregistrare/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Inregistrare/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Inregistrare/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
