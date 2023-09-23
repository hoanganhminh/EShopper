using EShopperAPI.Models;

namespace EShopperAPI.Services.Contracts
{
    public interface IProductService
    {
        public Task<List<Product>> GetAllProducts();
    }
}
