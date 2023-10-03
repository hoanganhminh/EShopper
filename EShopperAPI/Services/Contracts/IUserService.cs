using EShopperAPI.Models;

namespace EShopperAPI.Services.Contracts
{
    public interface IUserService
    {
        public Task<List<User>> GetAllUsers();
    }
}
