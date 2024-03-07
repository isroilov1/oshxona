namespace oshhona.BusinesLogic.DTOs.FoodTypeDtos;

public class FoodTypeDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string ImagePath { get; set; } = "";
    public IFormFile? file { get; set; }
    public int CategoryId { get; set; }
    public CategoryDto Category { get; set; } = new();
    public List<Foods>? Foods { get; set; }

    public static implicit operator FoodTypeDto(FoodTypes foodType)
        => new()
        {
            Id = foodType.Id,
            Name = foodType.Name,
            ImagePath = foodType.ImageUrl,
            CategoryId = foodType.CategoryId,
            Foods = foodType.Foods
        };
}
