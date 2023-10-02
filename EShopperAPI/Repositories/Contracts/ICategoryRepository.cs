using EShopperAPI.Models;

namespace EShopperAPI.Repositories.Contracts
{
    public interface ICategoryRepository
    {
        public Task<List<Category>> GetAllCategories();

    }
}
