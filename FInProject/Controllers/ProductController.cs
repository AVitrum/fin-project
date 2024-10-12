using FInProject.Models;
using FInProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FInProject.Controllers;

public class ProductController : Controller
{
    private readonly IProductRepository _productRepository;
    
    public ProductController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    
    public async Task<IActionResult> Index()
    {
        IEnumerable<Product> products = await _productRepository.GetProductsAsync();
        return View(products);
    }

    public ActionResult Create()
    {
        Product product = new Product();
        return View(product);
    }

    [HttpPost]
    public ActionResult Create(Product product)
    {
        if (ModelState.IsValid)
        {
            _productRepository.AddProductAsync(product);
            return RedirectToAction(nameof(Index));
        }

        return View(product);
    }
}