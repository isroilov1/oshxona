namespace oshhona.Areas.Admin.Data.Repositories
{
    public class OrderRepository(AppDbContext dbContext) :
        Repository<Order>(dbContext), IOrderInterface
    {
    }
}
