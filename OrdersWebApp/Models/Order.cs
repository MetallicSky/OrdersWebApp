using System.ComponentModel.DataAnnotations;

<<<<<<< HEAD
namespace YourNamespace.Models
=======
namespace OrdersWebApp.Models
>>>>>>> d86c37d06541f67d71a9b6df8dd2f3e5d6a36c68
{
    public class Order
    {
        [Key]
<<<<<<< HEAD
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
=======
        public int OrderId { get; set; }

        [Required]
        public string SenderCity { get; set; }

        [Required]
        public string SenderAddress { get; set; }

        [Required]
        public string RecipientCity { get; set; }

        [Required]
        public string RecipientAddress { get; set; }

        [Required]
        public decimal CargoWeight { get; set; }

        [Required]
        public DateTime PickupDate { get; set; }

        public string OrderNumber { get; set; } = Guid.NewGuid().ToString().Substring(0, 8);
>>>>>>> d86c37d06541f67d71a9b6df8dd2f3e5d6a36c68
    }
}