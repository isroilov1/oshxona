namespace oshhona.BusinesLogic.DTOs.CategoryDtos;

public class CategoryDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string ImagePath { get; set; } = string.Empty;
    public List<FoodTypes>? FoodTypes { get; set; }

    public static implicit operator CategoryDto(Category category)
        => new()
        {
            Id = category.Id,
            Name = category.Name,
            ImagePath = category.ImageUrl,
            FoodTypes = category.FoodTypes
        };
}
