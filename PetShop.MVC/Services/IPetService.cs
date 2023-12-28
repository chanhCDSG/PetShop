using PetShop.MVC.Models;
using System.Text.Json.Serialization;


namespace PetShop.MVC.Services
{
    public interface IPetService
    {
        Task<IEnumerable<Pet>> GetAllPets();
        bool CreatePet(Pet Pet);
        Task<Pet> GetPetById(int PetId);
        bool UpdatePet(Pet pet);
        bool DeletePet(int PetId);
    }
}
