namespace oshhona.BusinesLogic.DTOs.FoodTypeDtos;

public class UpdateFoodTypeDto : FoodTypeDto
{
    public List<CategoryDto> Categories { get; set; } = new();
}
