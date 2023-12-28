using Microsoft.AspNetCore.Mvc;
using PetShop.MVC.Models;
using PetShop.MVC.Services;
using System.Diagnostics;

namespace PetShop.MVC.Controllers
{
    public class HomeController : Controller
    {
     
        private readonly IPetService _service;

        public HomeController(IPetService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult PetsIndex()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public async Task<IActionResult> Pets()
        {
            var allPets = await _service.GetAllPets();
            return View("Admin/Pet/Pets", allPets);
        }
        public IActionResult CreatePet()
        {
            return View("Admin/Pets/CreatePet");
        }
    }
}
