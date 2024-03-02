using Oshxona.Data.Entities;

namespace oshhona.Data.Entities;

public class Order : BaseEntity
{
    public int UserId { get; set; }
    public User User { get; set; } = new();
    public DateTime Date { get; set; } = DateTime.Now;

    public int FoodId { get; set; }
    public Foods Food { get; set; } = new();
    public string ModelName { get; set; } = null!;
    public double Price { get; set; }
}