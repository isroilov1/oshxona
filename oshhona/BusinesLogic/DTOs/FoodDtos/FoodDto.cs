
namespace oshhona.BusinesLogic.DTOs.FoodDtos;

public class FoodDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public double Price { get; set; }
    public string ImagePath { get; set; } = "";
    public IFormFile? file { get; set; }
    public int FoodTypeId { get; set; }
    public FoodTypeDto FoodType { get; set; } = new();
}
