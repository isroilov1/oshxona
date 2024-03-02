using Oshxona.Data.Entities;
using Oshxona.Data.Inrterfaces;

namespace oshhona.Data.Repositories
{
    public class OrderRepositoryy(AppDbContext dbContext) :
        Repository<Image>(dbContext), IOrderInterface
    {
    }
}
