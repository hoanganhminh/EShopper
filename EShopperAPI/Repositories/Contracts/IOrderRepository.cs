using EShopperAPI.Models;

namespace EShopperAPI.Repositories.Contracts
{
    public interface IOrderRepository
    {
        public Task<List<Order>> GetAllOrders();

    }
}
