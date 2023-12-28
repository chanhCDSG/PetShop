using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetShop.Models
{
    [Table("Pets")]
    public class Pet
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [Column("pet_name")]
        public string? Name { get; set; } 
        [Required]
        [Column("pet_age")]
        public int? Age { get; set; }
        [Required]
        [Column("pet_description")]
        public string? Description { get; set; }
        [Required]
        public double? Price { get; set; }
        [Column("pet_img")]
        public string? Image { get; set; }
        [Column("pet_created_date")]
        public DateTime CreatedDate { get; set; }
        [Column("pet_updated_date")]
        public DateTime UpdatedDate { get; set; }

        public int? OrderItemId { get; set; }
        public int? PetCategoryId { get; set; }
        [ForeignKey("OrderItemId")]
        public OrderItem? OrderItem { get; set; }
        [ForeignKey("PetCategoryId")]
        public PetCategory? Category { get; set; }
    }
}
