using EShopperAPI.Models;

namespace EShopperAPI.Services.Contracts
{
    public interface IOrderService
    {
        public Task<List<Order>> GetAllOrders();
    }
}
