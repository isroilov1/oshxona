using oshhona.Areas.Admin.Data;
using oshhona.Areas.Admin.Data.Entities;
using oshhona.Areas.Admin.Data.Interfaces;

namespace oshhona.Areas.Admin.Data.Repositories;

public class CategoryRepository(AppDbContext dbContext)
    : Repository<Category>(dbContext), ICategoryInterface
{
}
