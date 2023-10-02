using EShopperAPI.Models;
using EShopperAPI.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace EShopperAPI.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly EShopperContext _context;

        public OrderRepository(EShopperContext context)
        {
            _context = context;
        }

        public async Task<List<Order>> GetAllOrders()
        {
            try
            {
                var orders = await _context.Orders.ToListAsync();
                return orders;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
