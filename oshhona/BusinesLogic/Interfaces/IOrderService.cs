using oshhona.Areas.Admin.Data.Entities;

namespace oshhona.BusinesLogic.Interfaces;

public interface IOrderService
{
    public IEnumerable<Order> GetAll();
    public Order GetById(int id);
    public void Add(int foodId);
}
