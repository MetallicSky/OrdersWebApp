using Microsoft.EntityFrameworkCore;
using OrderWebAppBlazor.Shared;

namespace OrderWebAppBlazor.Server.Data;

public class OrderDbContext : DbContext
{
    public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options) { }

    public DbSet<Order> Orders => Set<Order>();
}
