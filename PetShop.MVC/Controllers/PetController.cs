//using PetShop.MVC.API.Models;
using PetShop.MVC.Models;
using PetShop.MVC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

namespace PetShop.MVC.Controllers
{
    public class PetController : Controller
    {
        private readonly IPetService _service;
        public PetController(IPetService service)
        {
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }
        public async Task<IActionResult> Pets()
        {
            var allPets = await _service.GetAllPets();
            return View("~/Pages/Admin/Pet/Pets.cshtml", allPets);
        }
        public IActionResult CreatePetForm()
        {
            ViewData["Title"] = "Add Pet";
            return View("~/Pages/Admin/Pet/CreatePet.cshtml"); // ~/Views/Admin/Pet/CreatePet.cshtml
        }
        [HttpPost]
        public IActionResult InsertPet(Pet Pet)
        {
            if (!ModelState.IsValid)
            {
                Console.WriteLine("Can't add!");
                return View("~/Pages/Admin/Pet/CreatePet.cshtml"); // ~/Pages/Failed.cshtml
            }
            Pet newPet = new Pet();
            newPet.Name = Pet.Name;
            newPet.Description = Pet.Description;
            newPet.Price = Pet.Price;
            newPet.Image = Pet.Image;
            newPet.CreatedDate = Pet.CreatedDate;
            newPet.UpdatedDate = Pet.UpdatedDate;
            bool result = _service.CreatePet(newPet);
            if(result)
            {
                ModelState.Clear();
                return RedirectToAction("Pets"); // ~/Pages/Success.cshtml
            }
            return View("~/Pages/Failed.cshtml");
        }
        public IActionResult DetailsPetById(int id)
        {
            if (!ModelState.IsValid)
            {
                return View("~/Views/Admin/Pet/Pets.cshtml");
            }
            Task<Pet> PetGetById = _service.GetPetById(id);
            return View("~/Views/Admin/Pet/Details.cshtml", PetGetById);
        }
        public IActionResult EditPetForm(int id)
        {
            if (!ModelState.IsValid)
            {
                return View("~/Views/Admin/Pet/Pets.cshtml");
            }
            Task<Pet> PetGetById = _service.GetPetById(id);
            Pet castTypeForPet = PetGetById.Result;
            return View("~/Views/Admin/Pet/EditPetForm.cshtml", castTypeForPet);
        }
        [HttpPost]
        public IActionResult EditPet(Pet Pet)
        {
            if(!ModelState.IsValid)
            {
                return View("~/Views/Admin/Pet/EditPetForm.cshtml");
            }
            Console.WriteLine(Pet.Id + Pet.Name + Pet.Description + Pet.Price + Pet.Image + Pet.CreatedDate + Pet.UpdatedDate);
            if(_service.UpdatePet(Pet)) 
            {
                return View("~/Views/Admin/Pet/Pets.cshtml");
            }
            return View("~/Pages/Failed.cshtml");
        }
        [HttpGet]
        public IActionResult DeletePetById(int id)
        {
            if(_service.DeletePet(id) == true)
            {
                return View("~/Pages/Success.cshtml");
            }
            return View("~/Pages/Failed.cshtml");
            
        }
    }
}
