using oshhona.Areas.Admin.Data.Entities;

namespace oshhona.BusinesLogic.Common;

public static class Mapper
{
    /*public static CategoryDto ToCategoryDto(this Category category)
        => new()
        {
            Id = category.Id,
            Name = category.Name
        };

    public static BrendDto ToBrendDto(this Brend brend)
        => new()
        {
            Id = brend.Id,
            Name = brend.Name
        };*/

    public static FoodDto ToFoodDto(this Foods food)
        => new()
        {
            Id = food.Id,
            Name = food.Name,
            Description = food.Description,
            Price = food.Price,
            ImagePath = food.ImageUrl,
            FoodTypeId = food.FoodTypeId,
            FoodType = (FoodTypeDto)food.FoodType
        };

    public static FoodTypeDto ToFoodTypeDto(this FoodTypes food)
        => new()
        {
            Id = food.Id,
            Name = food.Name,
            ImagePath = food.ImageUrl,
            Foods = food.Foods,
            Category = (CategoryDto)food.Category
        };
}
