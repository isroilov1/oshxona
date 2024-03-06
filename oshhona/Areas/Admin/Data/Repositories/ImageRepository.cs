using oshhona.Areas.Admin.Data;
using oshhona.Areas.Admin.Data.Entities;
using oshhona.Areas.Admin.Data.Interfaces;

namespace oshhona.Areas.Admin.Data.Repositories;

public class ImageRepository(AppDbContext dbContext) :
    Repository<Image>(dbContext), IImageInterface
{
}
