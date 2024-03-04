
namespace Oshxona.Data.Inrterfaces;

public interface IUnitOfWork
{
    IFoodInterface Foods { get; }
    IFoodTypeInterface FoodType { get; }
    ICategoryInterface Categories { get; }
    IOrderInterface Images { get; }
    //IOrderInterface Orders { get; }
    IUserInterface Users { get; }
}
