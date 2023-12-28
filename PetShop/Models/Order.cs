using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShop.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [Required]
        public int Id { get; set; }
    
       public int? CustomerId { get; set; }
  
        public int? ShipmentId { get; set; }



        public Customer Customer { get; set; } = null!;
        public ICollection<OrderItem>? OrderItems { get; set; }
      
        public Shipment? Shipment { get; set; } 
    }
}
