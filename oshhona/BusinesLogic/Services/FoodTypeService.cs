using oshhona.BusinesLogic.DTOs.CategoryDtos;

namespace oshhona.BusinesLogic.Services;

public class FoodTypeService(IUnitOfWork unitOfWork,
                             IFileService fileService)
    : IFoodTypeService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IFileService _fileService = fileService;

    public void Create(AddFoodTypeDto FoodDto)
    {
        if (FoodDto == null)
        {
            throw new CustomException("", "FoodTypeDto was null");
        }
        if (string.IsNullOrEmpty(FoodDto.Name))
        {
            throw new CustomException("Name", "Food name is required");
        }
        if (FoodDto.Name.Length < 3 || FoodDto.Name.Length > 30)
        {
            throw new CustomException("Name", "FoodType name must be between 3 and 30 characters");
        }
        if (FoodDto.file == null)
        {
            throw new CustomException("file", "FoodType image is required");
        }

        FoodTypes FoodType = new()
        {
            Name = FoodDto.Name,
            ImageUrl = _fileService.UploadImage(FoodDto.file),
            CategoryId = FoodDto.CategoryId,
            Category = null
        };
        _unitOfWork.FoodType.Add(FoodType);
        
    }

    public void Delete(int id)
    {
        var foodType = _unitOfWork.FoodType.GetById(id);

        if (foodType == null)
        {
            throw new CustomException("", "FoodType not found");
        }
        _fileService.DeleteImage(foodType.ImageUrl);
        _unitOfWork.FoodType.Delete(foodType.Id);
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
            throw new CustomException("", "FoodType not found");
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
        if (string.IsNullOrEmpty(FoodDto.Name))
        {
            throw new CustomException("", "FoodType name is required");
        }

        if (FoodDto.Name.Length < 3 || FoodDto.Name.Length > 30)
        {
            throw new CustomException("", "FoodType name must be between 3 and 30 characters");
        }

        Food.Name = FoodDto.Name;
        Food.ImageUrl = FoodDto.ImagePath;
        Food.CategoryId = FoodDto.CategoryId;

        _unitOfWork.FoodType.Update(Food);
    }
}