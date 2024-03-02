using oshhona.BusinesLogic.Common;

namespace oshhona.BusinesLogic.Services;

public class FoodService(IUnitOfWork unitOfWork)
    : IFoodService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public void Create(AddFoodDto FoodDto)
    {
        if (FoodDto == null)
        {
            throw new CustomException("", "FoodDto was null");
        }

        if (string.IsNullOrEmpty(FoodDto.Name))
        {
            throw new CustomException("Name", "Food name is required");
        }

        for (int i = 0; i < 100; i++)
        {
            Foods Food = new()
            {
                Name = FoodDto.Name,
                Description = FoodDto.Description,
                Price = FoodDto.Price,
                CategoryId = FoodDto.CategoryId,
                Category = null
            };
            _unitOfWork.Foods.Add(Food);
        }
    }

    public void Delete(int id)
    {
        var Food = _unitOfWork.Foods.GetById(id);
        if (Food == null)
        {
            throw new CustomException("", "Food not found");
        }

        _unitOfWork.Foods.Delete(Food.Id);
    }

    public List<FoodDto> GetAll()
    {
        var Foods = _unitOfWork.Foods.GetFoodsWithReleations();
        var dtos = Foods.Select(Food => Food.ToFoodDto());
        return dtos.ToList();
    }

    public FoodDto GetById(int id)
    {
        var Food = _unitOfWork.Foods.GetFoodsWithReleations().FirstOrDefault(c => c.Id == id);
        if (Food == null)
        {
            throw new CustomException("", "Food not found");
        }

        return Food.ToFoodDto();
    }

    public void Update(UpdateFoodDto FoodDto)
    {
        var Food = _unitOfWork.Foods.GetById(FoodDto.Id);
        if (Food == null)
        {
            throw new CustomException("", "Food not found");
        }

        Food.Name = FoodDto.Name;
        Food.Description = FoodDto.Description;
        Food.Price = FoodDto.Price;
        Food.CategoryId = FoodDto.CategoryId;

        _unitOfWork.Foods.Update(Food);
    }
}