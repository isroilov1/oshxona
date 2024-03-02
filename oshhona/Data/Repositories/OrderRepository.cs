using oshhona.Data.Entities;
using oshhona.Data.Inrterfaces;
using Oshxona.Data.Entities;

namespace oshhona.Data.Repositories
{
    public class OrderRepository(AppDbContext dbContext) :
        Repository<Order>(dbContext), IOrderInterface
    {
    }
}
