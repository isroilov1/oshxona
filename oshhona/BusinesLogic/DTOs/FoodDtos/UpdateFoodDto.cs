namespace oshhona.BusinesLogic.DTOs.FoodDtos;

public class UpdateFoodDto : AddFoodDto
{
    public int Id { get; set; }
    public IFormFile? file { get; set; }
}
