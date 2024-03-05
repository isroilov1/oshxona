namespace oshhona.BusinesLogic.DTOs.FoodTypeDtos;

public class UpdateFoodTypeDto : FoodTypeDto
{
    public int Id { get; set; }
    public IFormFile? file { get; set; }
}
