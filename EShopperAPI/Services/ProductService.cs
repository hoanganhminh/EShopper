using EShopperAPI.Models;
using EShopperAPI.Repositories.Contracts;
using EShopperAPI.Services.Contracts;

namespace EShopperAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public async Task<List<Product>> GetAllProducts()
        {
            try
            {
                var products = new List<Product>();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
