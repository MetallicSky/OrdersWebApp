using System.ComponentModel.DataAnnotations;

namespace YourNamespace.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; } // Auto-generated order number.

        [Required]
        [MaxLength(100)]
        public string SenderCity { get; set; }

        [Required]
        [MaxLength(200)]
        public string SenderAddress { get; set; }

        [Required]
        [MaxLength(100)]
        public string RecipientCity { get; set; }

        [Required]
        [MaxLength(200)]
        public string RecipientAddress { get; set; }

        [Required]
        [Range(0.1, 10000, ErrorMessage = "Weight must be between 0.1 and 10,000.")]
        public double CargoWeight { get; set; }

        [Required]
        public DateTime CargoPickupDate { get; set; }
    }
}
