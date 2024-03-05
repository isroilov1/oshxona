namespace oshhona.BusinesLogic.DTOs.FoodDtos;

public class UpdateFoodDto : FoodDto
{
    public List<FoodTypeDto> FoodTypes { get; set; } = new();
}
