namespace oshhona.Models;

public class OrderItem
{
    public FoodDto Food { get; set; } = new();
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}
