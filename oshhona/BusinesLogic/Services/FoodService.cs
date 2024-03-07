namespace oshhona.BusinesLogic.Services;

public class FoodService(IUnitOfWork unitOfWork,
                         IFileService fileService)
    : IFoodService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IFileService _fileService = fileService;

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

        Foods Food = new()
        {
            Name = FoodDto.Name,
            Description = FoodDto.Description,
            Price = FoodDto.Price,
            ImageUrl = _fileService.UploadImage(FoodDto.file),
            FoodTypeId = FoodDto.FoodTypeId,
            FoodType = null
        };
        _unitOfWork.Foods.Add(Food);
        
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
        var Foods = _unitOfWork.Foods.GetFoodWithReleations();
        var dtos = Foods.Select(Food => Food.ToFoodDto());
        var list = dtos.ToList();
        return list;
    }

    public FoodDto GetById(int id)
    {
        var Food = _unitOfWork.Foods.GetFoodWithReleations().FirstOrDefault(c => c.Id == id);
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

        if (FoodDto.file != null)
        {
            Food.ImageUrl = _fileService.UploadImage(FoodDto.file);
        }

        Food.Name = FoodDto.Name;
        Food.Description = FoodDto.Description;
        Food.Price = FoodDto.Price;
        Food.FoodTypeId = FoodDto.FoodTypeId;

        _unitOfWork.Foods.Update(Food);
    }
}
