namespace backend.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
    public List<string> Variants { get; set; } = new();
    public bool Available { get; set; } = true;
}
