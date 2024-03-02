namespace Oshxona.Data.Entities
{
    public class Foods : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public double Price { get; set; }
        public string ImageUrl { get; set; } = "";

        public int CategoryId { get; set; }
        public Category Category { get; set; } = new();
        //public List<Order> Orders { get; set; } = new();
    }
}
