using EShopperAPI.Models;
using EShopperAPI.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace EShopperAPI.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly EShopperContext _context;

        public async Task<List<Product>> GetAllProducts()
        {
            try
            {
                var jobs = await _context.Products.ToListAsync();
                return jobs;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
