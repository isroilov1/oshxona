using oshhona.Areas.Admin.Data.Entities;

namespace oshhona.Areas.Admin.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options) { }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Foods> Foods { get; set; }
    public DbSet<FoodTypes> FoodType { get; set; }
    public DbSet<Image> Images { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        User superUser = new()
        {
            Id = 1,
            FISH = "Isroilov",
            Tel = "+998991114515",
            Password = PasswordHasher.HashPassword("Ismoiljon.4515"),
            Address = "Database",
            Role = Role.Admin
        };

        modelBuilder.Entity<User>()
            .HasData(superUser);

        base.OnModelCreating(modelBuilder);
    }
}
