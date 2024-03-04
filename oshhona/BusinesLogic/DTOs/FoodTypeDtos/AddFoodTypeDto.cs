namespace oshhona.BusinesLogic.DTOs.FoodTypeDtos;

public class AddFoodTypeDto
{
    public string Name { get; set; } = null!;
    public string ImagePath { get; set; } = "";
    public int CategoryId { get; set; }
    public List<CategoryDto> Categories { get; set; } = new();
}
