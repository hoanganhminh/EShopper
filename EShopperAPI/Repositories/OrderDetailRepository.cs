using EShopperAPI.Models;
using EShopperAPI.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace EShopperAPI.Repositories
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly EShopperContext _context;

        public OrderDetailRepository(EShopperContext context)
        {
            _context = context;
        }

        public async Task<List<OrderDetail>> GetAllIOrderDetails()
        {
            try
            {
                var orderDetails = await _context.OrderDetails.ToListAsync();
                return orderDetails;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
