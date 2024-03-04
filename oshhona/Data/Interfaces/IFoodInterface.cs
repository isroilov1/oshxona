public interface IFoodInterface : IRepository<Foods>
{
    public List<Foods> GetFoodWithReleations();
}
