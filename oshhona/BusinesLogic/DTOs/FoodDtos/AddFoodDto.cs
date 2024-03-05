
namespace oshhona.BusinesLogic.DTOs.FoodDtos;

public class AddFoodDto : FoodDto
{
    public int FoodTypeId { get; set; }

    public List<FoodTypeDto> FoodTypes { get; set; } = new();
}
