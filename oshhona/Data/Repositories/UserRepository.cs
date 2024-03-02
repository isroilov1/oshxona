
namespace oshhona.Data.Repositories
{
    public class UserRepository(AppDbContext dbContext) :
        Repository<User>(dbContext), IUserInterface
    {
    }
}
