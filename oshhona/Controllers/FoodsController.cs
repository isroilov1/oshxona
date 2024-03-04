﻿namespace oshhona.Controllers;

public class FoodsController(IFoodService FoodService,
IFoodTypeService foodService)
    : Controller
{
    private readonly IFoodService _FoodService = FoodService;
    private readonly IFoodTypeService _foodService = foodService;

    public IActionResult Index(int pageNumber = 1)
    {
        var ovqatlar = _FoodService.GetAll();
        var pageModel = new PageModel<FoodDto>(ovqatlar, pageNumber);
        return View(pageModel);
    }

    public IActionResult Add()
    {
        var foods = _foodService.GetAll();

        AddFoodDto dto = new()
        {
            FoodType = foods
        };

        return View(dto);
    }

    [HttpPost]
    public IActionResult Add(AddFoodDto dto)
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
            return RedirectToAction("error", "home", new { url = "/categories/index" });
        }
    }

    public IActionResult Edit(int id)
    {
        try
        {
            var Food = _FoodService.GetById(id);
            UpdateFoodDto dto = new()
            {
                Id = Food.Id,
                Name = Food.Name,
                Description = Food.Description,
                Price = Food.Price,
                FoodTypeId = Food.FoodType.Id,
                FoodType = _foodService.GetAll(),
            };

            return View(dto);
        }
        catch (CustomException)
        {
            return RedirectToAction("error", "home", new { url = "/categories/index" });
        }
    }

    [HttpPost]
    public IActionResult Edit(UpdateFoodDto dto)
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
            return RedirectToAction("error", "home", new { url = "/categories/index" });
        }
    }
}