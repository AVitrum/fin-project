using System.ComponentModel.DataAnnotations;

namespace FInProject.Models;

public class Asset(int code, string originalName)
{
    [Key]
    public Guid Id { get; set; }
    public int Code { get; set; } = code;
    public string OriginalName { get; set; } = originalName;
    public decimal AtStart { get; set; }
    public decimal AtEnd { get; set; }
}