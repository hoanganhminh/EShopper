using EShopperAPI.Models;

namespace EShopperAPI.Repositories.Contracts
{
    public interface IUserRepository
    {
        public Task<List<User>> GetAllUsers();

    }
}
