﻿
namespace oshhona.Data.Repositories
{
    public class OrderRepository(AppDbContext dbContext) :
        Repository<Order>(dbContext), IOrderInterface
    {
    }
}
