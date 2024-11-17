namespace OrderWebAppBlazor.Shared
{
    public class Order
    {
        public int Id { get; set; }
        public string SenderCity { get; set; } = string.Empty;
        public string SenderAddress { get; set; } = string.Empty;
        public string RecipientCity { get; set; } = string.Empty;
        public string RecipientAddress { get; set; } = string.Empty;
        public double CargoWeight { get; set; }
        public DateTime PickupDate { get; set; }
    }
}
