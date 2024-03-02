using Microsoft.EntityFrameworkCore;
using oshhona.Data.Entities;
using Oshxona.Data.Entities;
namespace oshhona.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options) { }

    public DbSet<Foods> Foods { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Image> Images { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        User superUser = new()
        {
            Id = 1,
            FISH = "Isroilov",
            Tel = "+998901234567",
            Password = "Super.Admin",
            Address = "Database",
            Role = Role.Admin
        };

        modelBuilder.Entity<User>()
            .HasData(superUser);

        base.OnModelCreating(modelBuilder);
    }
}
