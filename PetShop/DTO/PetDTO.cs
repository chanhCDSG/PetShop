using System.ComponentModel.DataAnnotations;

namespace PetShop.DTO
{
    public class PetDTO
    {
        [Required]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }
    }
}
