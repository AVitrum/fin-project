using FInProject.Models;

namespace FInProject.Repositories;

public interface IProductRepository
{
    Task<bool> AddProductAsync(Product product);
    Task<IEnumerable<Product>> GetProductsAsync();
}