using oshhona.BusinesLogic.DTOs.FoodDtos;

namespace oshhona.BusinesLogic.Interfaces;

public interface IFoodService
{
    List<FoodDto> GetAll();
    FoodDto GetById(int id);
    void Create(AddFoodDto carDto);
    void Update(UpdateFoodDto carDto);
    void Delete(int id);
}
