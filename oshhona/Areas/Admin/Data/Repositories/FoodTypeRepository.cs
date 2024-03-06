using oshhona.Areas.Admin.Data;
using oshhona.Areas.Admin.Data.Entities;
using oshhona.Areas.Admin.Data.Interfaces;

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
