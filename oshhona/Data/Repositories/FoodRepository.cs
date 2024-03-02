using oshhona.BusinesLogic.DTOs.FoodDtos;
using oshhona.Data.Inrterfaces;
using Oshxona.Data.Entities;

namespace oshhona.Data.Repositories
{
    public class FoodRepository(AppDbContext dbContext)
    : Repository<Foods>(dbContext), IFoodInterface
    {
    }
}
