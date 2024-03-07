namespace oshhona.Areas.Admin.Data.Repositories;

public class FoodRepository(AppDbContext dbContext)
: Repository<Foods>(dbContext), IFoodInterface
{
    public List<Foods> GetFoodWithReleations()
    => _dbContext.Foods
        .Include(c => c.FoodType)
        .ToList();
}
