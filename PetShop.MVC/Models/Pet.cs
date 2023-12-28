using System.ComponentModel.DataAnnotations;

namespace PetShop.MVC.Models
{
    public class Pet
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter Pet's name!")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please enter Pet's description!")]
       
        public int? Age { get; set; }
        [Required(ErrorMessage = "Please enter Pet's Age!")]
        public string? Description { get; set; }
        [Required(ErrorMessage = "Please enter Pet's price!")]
        public double? Price { get; set; }
        [Required(ErrorMessage = "Please enter Pet's image!")]
        public string? Image { get; set; }
        [Required(ErrorMessage = "Please enter Pet's created date!")]
        public DateTime CreatedDate { get; set; }
        [Required(ErrorMessage = "Please enter Pet's updated date!")]
        public DateTime UpdatedDate { get; set; }



    }
}
