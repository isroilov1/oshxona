using oshhona.Data.Inrterfaces;

namespace Oshxona.Data.Inrterfaces;

public interface IUnitOfWork
{
    IFoodInterface Cars { get; }
    ICategoryInterface Categories { get; }
    IOrderInterface Images { get; }
    //IOrderInterface Orders { get; }
    IUserInterface Users { get; }
}
