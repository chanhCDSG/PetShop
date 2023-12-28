using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShop.Models
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Column("customer_name")]
        public string? Name { get; set; }
        [Column("customer_email")]
        public string? Email { get; set; }
        [Column("customer_password")]
        public string? Password { get; set; }
        [Column("customer_PhoneNumber")]
        public int? PhoneNumber { get; set; }
        [Column]
        public string? Address { get; set; }

        [Column("customer_created_date")]
        public DateTime Created_Date { get; set; }
        [Column("customer_updated_date")]
        public DateTime Updated_Date { get; set; }
        public int? OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order? Order { get; set; }
    }
}
