using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShop.Models
{
    [Table("Shipments")]
    public class Shipment
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string? status { get; set; }
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; } = null!;
    }
}
