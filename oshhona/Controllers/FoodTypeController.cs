namespace oshhona.Controllers;

public class FoodTypeController(IFoodTypeService FoodTypeService,
ICategoryService categoryService)
: Controller
{
private readonly IFoodTypeService _FoodService = FoodTypeService;
private readonly ICategoryService _categoryService = categoryService;

public IActionResult Index(int pageNumber = 1)
{
    var moshinalar = _FoodService.GetAll();
    var pageModel = new PageModel<FoodTypeDto>(moshinalar, pageNumber);
    return View(pageModel);
}

public IActionResult Add()
{
    var categories = _categoryService.GetAll();

    AddFoodTypeDto dto = new()
    {
        Categories = categories
    };

    return View(dto);
}

[HttpPost]
public IActionResult Add(AddFoodTypeDto dto)
{
    try
    {
        _FoodService.Create(dto);
        return RedirectToAction("index");
    }
    catch (CustomException ex)
    {
        ModelState.AddModelError(ex.Key, ex.Message);
        return View(dto);
    }
}

public IActionResult Delete(int id)
{
    try
    {
        _FoodService.Delete(id);
        return RedirectToAction("index");
    }
    catch (CustomException)
    {
        return RedirectToAction("error", "home", new { url = "/foodtype/index" });
    }
}

public IActionResult Edit(int id)
{
    try
    {
        var Food = _FoodService.GetById(id);
        UpdateFoodTypeDto dto = new()
        {
            Id = Food.Id,
            Name = Food.Name,
            ImagePath = Food.ImagePath,
            CategoryId = Food.Category.Id
        };

        return View(dto);
    }
    catch (CustomException)
    {
        return RedirectToAction("error", "home", new { url = "/foodtype/index" });
    }
}

[HttpPost]
public IActionResult Edit(UpdateFoodTypeDto dto)
{
    try
    {
        _FoodService.Update(dto);
        return RedirectToAction("index");
    }
    catch (CustomException ex)
    {
        ModelState.AddModelError(ex.Key, ex.Message);
        return View(dto);
    }
}

public IActionResult Detail(int id)
{
    try
    {
        var Food = _FoodService.GetById(id);
        return View(Food);
    }
    catch (CustomException)
    {
        return RedirectToAction("error", "home", new { url = "/foodtype/index" });
    }
}
}
