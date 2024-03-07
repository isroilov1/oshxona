
namespace oshhona.BusinesLogic.DTOs.FoodDtos;

public class AddFoodDto : FoodDto
{
    public List<FoodTypeDto> FoodTypes { get; set; } = new();
}
