using oshhona.Areas.Admin.Data;
using oshhona.Areas.Admin.Data.Entities;
using oshhona.Areas.Admin.Data.Interfaces;

namespace oshhona.Areas.Admin.Data.Repositories
{
    public class UserRepository(AppDbContext dbContext) :
        Repository<User>(dbContext), IUserInterface
    {
    }
}
