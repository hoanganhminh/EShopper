using EShopperAPI.Data.RequestDTO;
using EShopperAPI.Models;

namespace EShopperAPI.Services.Contracts
{
    public interface IProductService
    {
        public Task<List<ProductResponse>> GetAllProducts();
    }
}
