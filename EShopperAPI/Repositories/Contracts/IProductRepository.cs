using EShopperAPI.Models;

namespace EShopperAPI.Repositories.Contracts
{
    public interface IProductRepository
    {
        public Task<List<Product>> GetAllProducts();

    }
}
