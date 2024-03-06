namespace oshhona.Models;

public class FoodsViewModel
{
    public PageModel<FoodDto>? PageModel { get; set; }
    public List<FoodTypeCheck>? FoodTypeChecks { get; set; }
}

public class FoodTypeCheck
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool IsChecked { get; set; }
}
