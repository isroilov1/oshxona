using oshhona.BusinesLogic.DTOs.CategoryDtos;

namespace oshhona.BusinesLogic.DTOs.FoodDtos;

public class AddFoodDto
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public double Price { get; set; }
    public int CategoryId { get; set; }

    public List<CategoryDto> Categories { get; set; } = new();
}