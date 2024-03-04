namespace oshhona.BusinesLogic.Interfaces;

public interface IFoodService
{
    List<FoodDto> GetAll();
    FoodDto GetById(int id);
    void Create(AddFoodDto foodDto);
    void Update(UpdateFoodDto foodDto);
    void Delete(int id);
}
