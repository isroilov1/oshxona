namespace oshhona.BusinesLogic.DTOs.CategoryDtos;

public class AddCategoryDto
{
    public string Name { get; set; } = string.Empty;
    public IFormFile? file { get; set; }
}
