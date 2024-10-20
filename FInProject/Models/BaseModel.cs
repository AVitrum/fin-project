namespace FInProject.Models;

public class BaseModel
{
    protected BaseModel(string name)
    {
        Name = name;
    }
    
    public Guid Id { get; init; }
    public string Name { get; set; }
}