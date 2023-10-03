using EShopperAPI.Models;

namespace EShopperAPI.Services.Contracts
{
    public interface IOrderDetailService
    {
        public Task<List<OrderDetail>> GetAllOrderDetails();
    }
}
