namespace oshhona.BusinesLogic.Services;

public class FoodTypeService(IUnitOfWork unitOfWork)
    : IFoodTypeService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;

    public void Create(AddFoodTypeDto FoodDto)
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
            FoodTypes Food = new()
            {
                Name = FoodDto.Name,
                ImageUrl = FoodDto.ImagePath,
                CategoryId = FoodDto.CategoryId,
                Category = null
            };
            _unitOfWork.FoodType.Add(Food);
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

    public List<FoodTypeDto> GetAll()
    {
        var Foods = _unitOfWork.FoodType.GetFoodTypeWithReleations();
        var dtos = Foods.Select(Food => Food.ToFoodTypeDto());
        return dtos.ToList();
    }

    public FoodTypeDto GetById(int id)
    {
        var Food = _unitOfWork.FoodType.GetFoodTypeWithReleations().FirstOrDefault(c => c.Id == id);
        if (Food == null)
        {
            throw new CustomException("", "Food not found");
        }

        return Food.ToFoodTypeDto();
    }

    public void Update(UpdateFoodTypeDto FoodDto)
    {
        var Food = _unitOfWork.FoodType.GetById(FoodDto.Id);
        if (Food == null)
        {
            throw new CustomException("", "Food not found");
        }

        Food.Name = FoodDto.Name;
        Food.CategoryId = FoodDto.CategoryId;

        _unitOfWork.FoodType.Update(Food);
    }
}