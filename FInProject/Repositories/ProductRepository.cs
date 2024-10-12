using FInProject.Data;
using FInProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FInProject.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly ApplicationDbContext _context;
    
    public ProductRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<bool> AddProductAsync(Product product)
    {
        _context.Products.Add(product);
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<IEnumerable<Product>> GetProductsAsync()
    {
        return await _context.Products.ToListAsync();
    }
}