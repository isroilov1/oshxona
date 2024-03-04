
namespace oshhona.BusinesLogic.DTOs.FoodDtos;

public class AddFoodDto
{
    public string Name { get; set; } = null!;
    public string ImagePath { get; set; } = "";
    public string Description { get; set; } = "";
    public double Price { get; set; }
    public int FoodTypeId { get; set; }

    public List<FoodTypeDto> FoodType { get; set; } = new();
}