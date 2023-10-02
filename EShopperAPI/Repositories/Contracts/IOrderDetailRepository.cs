using EShopperAPI.Models;

namespace EShopperAPI.Repositories.Contracts
{
    public interface IOrderDetailRepository
    {
        public Task<List<OrderDetail>> GetAllIOrderDetails();

    }
}
