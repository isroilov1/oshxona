using oshhona.BusinesLogic.DTOs.FoodDtos;

namespace oshhona.Data.Inrterfaces;
//asdsfddd
public interface IFoodInterface
{
    List<FoodDto> GetAll();
    FoodDto GetById(int id);
    void Create(AddFoodDto carDto);
    void Update(UpdateFoodDto carDto);
    void Delete(int id);
}
