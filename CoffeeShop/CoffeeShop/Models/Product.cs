using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace CoffeeShop.Models;

[Index(nameof(Name), IsUnique = true)]
public class Product
{
    [Key]
    public int ProductId { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    public decimal Price { get; set; }

    public int CategoryId { get; set; }

    [ForeignKey(nameof(CategoryId))]
    public Category? Category { get; set; }

    internal static void DeleteProduct(string connectionString)
    {
        throw new NotImplementedException();
    }

    internal static void ReadProduct(string connectionString)
    {
        throw new NotImplementedException();
    }

    internal static void ShowAllProducts(string connectionString)
    {
        throw new NotImplementedException();
    }

    internal static void UpdateProduct(string connectionString)
    {
        throw new NotImplementedException();
    }
}
