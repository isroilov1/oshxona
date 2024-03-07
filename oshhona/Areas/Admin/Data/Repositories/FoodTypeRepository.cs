namespace oshhona.Areas.Admin.Data.Repositories
{
    public class FoodTypeRepository(AppDbContext dbContext)
    : Repository<FoodTypes>(dbContext), IFoodTypeInterface
    {
        public List<FoodTypes> GetFoodTypeWithReleations()
        => _dbContext.FoodType
            .Include(c => c.Category)
            .ToList();
    }
}
