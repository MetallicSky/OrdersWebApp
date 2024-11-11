using System.ComponentModel.DataAnnotations;

namespace OrdersWebApp.Models
{
    public class Order
    {
        [Key]
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
    }
}