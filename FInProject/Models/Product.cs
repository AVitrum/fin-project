using System.ComponentModel.DataAnnotations;

namespace FInProject.Models;

public class Product
{
    [Key]
    public Guid Id { get; init; }

    [Required, StringLength(256)] 
    public string ProductName { get; set; } = null!; // Стіл
    public decimal RawMaterialCost { get; set; } // 800
    public decimal AuxiliaryMaterialCost { get; set; } // 80 
    public decimal ScrapCost { get; set; } // 20
    public decimal BaseSalary { get; set; } // 1400
    public decimal AdditionalSalary { get; set; } // 300
    public decimal Esv => (BaseSalary + AdditionalSalary) * 0.22m; // 374
    public decimal PreparationCost => BaseSalary * 2; // 2800
    public decimal ManufacturingOverheads { get; set; } // 300
    public decimal AdministrativeExpenses => BaseSalary * 1.2m; // 1680
    
    public int Quantity { get; set; } // 5
    
    public decimal CalculateUnitCost() 
    {
        return RawMaterialCost + AuxiliaryMaterialCost + BaseSalary + AdditionalSalary + PreparationCost + ManufacturingOverheads + Esv - ScrapCost;
    }
    
    public decimal CalculateTotalCost() 
    {
        return CalculateUnitCost() * Quantity;
    }
}