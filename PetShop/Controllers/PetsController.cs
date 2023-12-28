using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetShop.DTO;
using PetShop.Models;

namespace PetShop.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<PetsController> _logger;
        //contructor
       public PetsController(ApplicationDbContext _context,ILogger<PetsController> _logger) {
            this._context = _context;
            this._logger = _logger;
        }

        [HttpGet("/GetAllPets")]
        public IEnumerable<Pet> Get()
        {
            var getAllPets = _context.pets.ToList();
            return getAllPets;
        }
        [HttpPost("/AddPets")]
        public IActionResult CreatePet(Pet Pet)
        {
            var result = _context.pets.Add(Pet);
            _context.SaveChanges();
            if (result != null)
            {
                return Ok("Add successfully!");
            }
            return BadRequest("Can't");
        }
        [HttpGet("/PetById/{id:int}")]
        public IActionResult GetPetById(int id)
        {
            var PetFound = _context.pets.FirstOrDefault(p => p.Id == id);
            return Ok(PetFound);
        }
        [HttpPost("/UpdatePet/")]
        public IActionResult UpdatePet(Pet Pet)
        {
            Pet? PetUpdate = _context.pets.Find(Pet.Id);
            PetUpdate.Name = Pet.Name;
            PetUpdate.Age = Pet.Age;
            PetUpdate.Description = Pet.Description;
            PetUpdate.Price = Pet.Price;
            PetUpdate.Image = Pet.Image;
            PetUpdate.CreatedDate = Pet.CreatedDate;
            PetUpdate.UpdatedDate = Pet.UpdatedDate;
            _context.Entry(PetUpdate).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return Ok(PetUpdate);
        }
        [HttpDelete("/PetDelete/{id:int}")]
        public string DeletePet(int id)
        {
            string result = "";
            var PetFound = _context.pets.Find(id);
            if (PetFound != null)
            {
                _context.Entry(PetFound).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                _context.SaveChanges();
                result = $"Delete Pet with id:{id} completed!";
            }
            else
            {
                result = $"The database has no id: {id}!";
            }
            return result;

        }


    }
}
    

