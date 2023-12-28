using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShop.Models
{
    [Table("OrderItems")]
    public class OrderItem
    {
        [Key]
        [Required]
        public int Id { get; set; }
     
      
     

        [Required]
        public DateTime? OrderDate { get; set; }

        public int? OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order? Order { get; set; }
        public ICollection<Pet>? Pets { get; set; }
       
    }
}
