using oshhona.Data.Inrterfaces;
using Oshxona.Data.Entities;

namespace oshhona.Data.Repositories
{
    public class UserRepository(AppDbContext dbContext) :
        Repository<User>(dbContext), IUserInterface
    {
    }
}
