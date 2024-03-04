namespace oshhona.BusinesLogic.Interfaces;

public interface IFoodTypeService
{
    List<FoodTypeDto> GetAll();
    FoodTypeDto GetById(int id);
    void Create(AddFoodTypeDto foodDto);
    void Update(UpdateFoodTypeDto foodDto);
    void Delete(int id);
}
