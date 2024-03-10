namespace Oshxona.Controllers;

public class HomeController(IFoodService FoodService,
                             IFoodTypeService FoodTypeService,
                             ICategoryService categoryService,
                             IOrderService orderService)
    : Controller
{
    private readonly IFoodService _foodService = FoodService;
    private readonly IFoodTypeService _foodTypeService = FoodTypeService;
    private readonly ICategoryService _categoryService = categoryService;
    private readonly IOrderService _orderService = orderService;

    public IActionResult Index()
    {
        var res = HttpContext.User;


        var Foods = _foodService.GetAll();
        var FoodTypes = _foodTypeService.GetAll();
        var categories = _categoryService.GetAll();

        IndexViewModel viewModel = new()
        {
            Foods = Foods,
            FoodTypes = FoodTypes,
            Categories = categories
        };

        return View(viewModel);
    }

    public IActionResult More(int id)
    {
        var Food = _foodService.GetById(id);
        return View(Food);
    }

    public IActionResult Shop()
    {
        var Foods = _foodService.GetAll();
        var FoodTypes = _foodTypeService.GetAll();
        var categories = _categoryService.GetAll();

        IndexViewModel viewModel = new()
        {
            Foods = Foods,
            FoodTypes = FoodTypes,
            Categories = categories
        };

        return View(viewModel);
    }

    public IActionResult Foods(int pageNumber = 1)
    {
        var foods = _foodService.GetAll();
        var pageModel = new PageModel<FoodDto>(foods, pageNumber, 12);
        var FoodTypes = _foodTypeService.GetAll();

        FoodsViewModel viewModel = new()
        {
            PageModel = pageModel,
            FoodTypeChecks = FoodTypes.Select(c => new FoodTypeCheck()
            { Id = c.Id, Name = c.Name }
                                                    ).ToList()
        };

        return View(viewModel);
    }

    public IActionResult Filter(FoodsViewModel model, int pageNumber = 1)
    {
        var foods = _foodService.GetAll();
        var selectedFoodTypeIds = model.FoodTypeChecks!.Where(b => b.IsChecked)
                                                .Select(b => b.Id)
                                                .ToList();

        if (selectedFoodTypeIds.Any())
        {
            foods = foods.Where(c => selectedFoodTypeIds.Contains(c.FoodType.Id))
                               .ToList();
        }

        var pageModel = new PageModel<FoodDto>(foods, pageNumber, 12);

        FoodsViewModel viewModel = new()
        {
            PageModel = pageModel,
            FoodTypeChecks = model.FoodTypeChecks
        };

        return View("Foods", viewModel);
    }

    [Authorize(AuthenticationSchemes = "User")]
    public IActionResult Order(int foodId)
    {
        _orderService.Add(foodId);
        return RedirectToAction("Index");
    }
}