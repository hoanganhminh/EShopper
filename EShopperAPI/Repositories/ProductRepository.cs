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
                var products = await _context.Products.ToListAsync();
                return products;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
