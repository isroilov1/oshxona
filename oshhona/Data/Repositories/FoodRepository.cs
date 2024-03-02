
namespace oshhona.Data.Repositories
{
    public class FoodRepository(AppDbContext dbContext)
    : Repository<Foods>(dbContext), IFoodInterface
    {
        public List<Foods> GetFoodsWithReleations()
        => _dbContext.Foods
            .Include(c => c.Category)
            .ToList();
        
    }
}
