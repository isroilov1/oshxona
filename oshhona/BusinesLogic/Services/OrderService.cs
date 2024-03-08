namespace oshhona.BusinesLogic.Services;

public class OrderService(IUnitOfWork unitOfWork,
                          IAuthService authService)
    : IOrderService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IAuthService authService = authService;

    public void Add(int foodId)
    {
        var phoneNumber = authService.GetPhoneNumber(Role.User);
        var user = _unitOfWork.Users
                              .GetAll()
                              .FirstOrDefault(u => u.Tel == phoneNumber);
        var food = _unitOfWork.Foods.GetById(foodId);

        Order order = new()
        {
            UserId = user.Id,
            User = null,
            FoodId = food.Id,
            Food = null,
            ModelName = food.Name,
            Date = DateTime.Now,
            Price = food.Price
        };

        _unitOfWork.Orders.Add(order);
    }

    public IEnumerable<Order> GetAll()
    {
        throw new NotImplementedException();
    }

    public Order GetById(int id)
    {
        throw new NotImplementedException();
    }
}