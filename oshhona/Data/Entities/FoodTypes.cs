namespace oshhona.Data.Entities;

public class FoodTypes : BaseEntity
{
    public string Name { get; set; } = "";
    public string ImageUrl { get; set; } = "";
    public int CategoryId { get; set; }
    public Category Category { get; set; } = new();
    public List<Foods> Foods { get; set; } = new();
}
