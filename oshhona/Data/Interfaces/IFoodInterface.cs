
using Oshxona.Data.Entities;
using Oshxona.Data.Inrterfaces;

public interface IFoodInterface : IRepository<Foods>
{
    List<Foods> GetFoodsWithReleations();
}
