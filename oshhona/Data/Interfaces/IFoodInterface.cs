public interface IFoodInterface : IRepository<Foods>
{
    List<Foods> GetFoodsWithReleations();
}
