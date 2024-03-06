using oshhona.Areas.Admin.Data.Entities;
using oshhona.Areas.Admin.Data.Interfaces;

public interface IFoodInterface : IRepository<Foods>
{
    public List<Foods> GetFoodWithReleations();
}
