namespace oshhona.BusinesLogic.DTOs.FoodTypeDtos;

public class UpdateFoodTypeDto : AddFoodTypeDto
{
    public int Id { get; set; }
    public IFormFile? file { get; set; }
}
