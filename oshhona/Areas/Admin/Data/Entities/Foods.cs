namespace oshhona.Areas.Admin.Data.Entities
{
    public class Foods : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public double Price { get; set; }
        public string ImageUrl { get; set; } = "";

        public int FoodTypeId { get; set; }
        public FoodTypes FoodType { get; set; } = new();
        //public List<Order> Orders { get; set; } = new();
    }
}
