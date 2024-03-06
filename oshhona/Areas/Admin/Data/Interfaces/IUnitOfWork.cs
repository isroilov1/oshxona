namespace oshhona.Areas.Admin.Data.Interfaces;

public interface IUnitOfWork
{
    IFoodInterface Foods { get; }
    IFoodTypeInterface FoodType { get; }
    ICategoryInterface Categories { get; }
    IOrderInterface Orders { get; }
    IUserInterface Users { get; }
}
