using FInProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FInProject.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Product> Products { get; init; }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
}