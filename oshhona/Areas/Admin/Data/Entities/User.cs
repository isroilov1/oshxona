namespace oshhona.Areas.Admin.Data.Entities;

public class User : BaseEntity
{
    public string FISH { get; set; } = "";
    public string Tel { get; set; } = "";
    public string Password { get; set; } = "";
    public string Address { get; set; } = "";
    public Role Role { get; set; } = Role.User;

    public List<Order> Orders { get; set; } = new();
}

public enum Role
{
    Admin,
    User
}