using oshhona.Areas.Admin.Data.Entities;

namespace oshhona.Areas.Admin.Data.Interfaces;

public interface IFoodTypeInterface : IRepository<FoodTypes>
{
    List<FoodTypes> GetFoodTypeWithReleations();
}
