using PetShop.MVC.Helpers;
using PetShop.MVC.Models;
using PetShop.MVC.Services;
using System.Text.Json.Serialization;

namespace PetShop.MVC.Services
{
    public class PetService : IPetService
    {
        private readonly HttpClient _client;
        public const string BasePath = "/GetAllPets";
        public const string BasePath2 = "/AddPets";
        public const string BasePath3 = "/PetById/";
        public const string BasePath4 = "/UpdatePet/";
        public const string BasePath5 = "/PetDelete/";
        public PetService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
            _client.BaseAddress = new Uri("http://localhost:40080");
        }

        public async Task<IEnumerable<Pet>> GetAllPets()
        {
            var response = await _client.GetAsync(BasePath);
            //Console.WriteLine(_client.BaseAddress + BasePath);
            return await response.ReadContentAsync<List<Pet>>();
        }

        public bool CreatePet(Pet Pet)
        {
             bool outcome; 
             var response = _client.PostAsJsonAsync(BasePath2, Pet);
             response.Wait();
             var result = response.Result;
             if(result.IsSuccessStatusCode)
             {
                outcome = true;
             } else
             {
                outcome = false;
             }
             return outcome;
        }
        public async Task<Pet> GetPetById(int PetId)
        {
            var PetFoundById = await _client.GetAsync(BasePath3 + PetId);
            var result = await PetFoundById.ReadContentAsync<Pet>();
            Pet found = result;
            return found;
        }

        public bool UpdatePet(Pet Pet)
        {
            bool outcome;
            var response = _client.PostAsJsonAsync(BasePath4, Pet);
            if(response.Result.IsSuccessStatusCode)
            {
                outcome = true;
            } else
            {
                outcome = false;
            }
            //var result = response.ReadContentAsync<Pet>();
            return outcome;
        }

        public bool DeletePet(int PetId)
        {
            bool outcome;
            var response =  _client.DeleteAsync(BasePath5 + PetId);
            
            if(response.Result.IsSuccessStatusCode)
            {
                outcome = true;
            } else
            {
                outcome = false;
            }
            return outcome;
        }
    }
}
