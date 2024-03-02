using oshhona.Data.Inrterfaces;

namespace Oshxona.Data.Inrterfaces;

public interface IUnitOfWork
{
    IFoodInterface Foods { get; }
    ICategoryInterface Categories { get; }
    IOrderInterface Images { get; }
    //IOrderInterface Orders { get; }
    IUserInterface Users { get; }
}
