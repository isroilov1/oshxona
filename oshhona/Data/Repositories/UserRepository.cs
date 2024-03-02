using oshhona.Data.Inrterfaces;
using Oshxona.Data.Entities;

namespace oshhona.Data.Repositories
{
    public class UserRepositoryy(AppDbContext dbContext) :
        Repository<User>(dbContext), IUserInterface
    {
    }
}
