using CoffeeShop.Models;
using Microsoft.EntityFrameworkCore;
namespace CoffeeShop.Data;
public class ProductContext : DbContext
{
    public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Category> Categories => Set<Category>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite($"Data Source = ./Data/Products_Database.db");
}
