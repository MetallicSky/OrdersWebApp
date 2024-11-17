using Microsoft.EntityFrameworkCore;
using YourNamespace.Data;
using YourNamespace.Models;

namespace YourNamespace.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Order> Orders { get; set; }
    }
}

public static class DbInitializer
{
    public static void Initialize(ApplicationDbContext context)
    {
        // Ensure database is created
        context.Database.EnsureCreated();

        // Look for any existing orders
        if (context.Orders.Any())
        {
            return; // Database has been seeded
        }

        // Add dummy orders
        context.Orders.AddRange(
            new Order
            {
                SenderCity = "New York",
                SenderAddress = "123 Main St",
                RecipientCity = "Los Angeles",
                RecipientAddress = "456 Elm St",
                CargoWeight = 12.5,
                CargoPickupDate = DateTime.Today
            },
            new Order
            {
                SenderCity = "Chicago",
                SenderAddress = "789 Pine St",
                RecipientCity = "Houston",
                RecipientAddress = "101 Maple Ave",
                CargoWeight = 25.0,
                CargoPickupDate = DateTime.Today.AddDays(1)
            }
        );

        context.SaveChanges();
    }
}
