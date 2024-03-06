namespace oshhona.Models;

public class IndexViewModel
{
    public List<FoodDto> Foods { get; set; } = new();
    public List<FoodTypeDto> FoodTypes { get; set; } = new();
    public List<CategoryDto> Categories { get; set; } = new();
}