
namespace oshhona.Data.Repositories;

public class UnitOfWork(AppDbContext dbContext)
    : IUnitOfWork
{

    public IFoodInterface Foods => new FoodRepository(dbContext);

    public IFoodTypeInterface FoodType => new FoodTypeRepository(dbContext);

    public ICategoryInterface Categories => new CategoryRepository(dbContext);

    public IImageInterface Images => new ImageRepository(dbContext);

    public IOrderInterface Orders => new OrderRepository(dbContext);

    public IUserInterface Users => new UserRepository(dbContext);

    IOrderInterface IUnitOfWork.Images => throw new NotImplementedException();
}
