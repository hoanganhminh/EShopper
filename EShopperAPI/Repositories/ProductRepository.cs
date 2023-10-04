using EShopperAPI.Models;
using EShopperAPI.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace EShopperAPI.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly EShopperContext _context;

        public ProductRepository(EShopperContext context)
        {
            _context = context;
        }
        public async Task<List<Product>> GetAllProducts()
        {
            try
            {
                var products = await _context.Products
                    .Include(x => x.Category)
                    //.Include(x => x.Reviews)
                    .ToListAsync();
                return products;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
