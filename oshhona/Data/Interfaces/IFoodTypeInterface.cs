namespace oshhona.Data.Interfaces;

public interface IFoodTypeInterface : IRepository<FoodTypes>
{
    List<FoodTypes> GetFoodTypeWithReleations();
}
