using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShop.Models
{
    [Table("PetCategories")]
    public class PetCategory
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
      
        public ICollection<Pet>? Pets { get; set; }
    }
}
