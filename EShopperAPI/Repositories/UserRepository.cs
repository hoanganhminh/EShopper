using EShopperAPI.Models;
using EShopperAPI.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace EShopperAPI.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly EShopperContext _context;

        public UserRepository(EShopperContext context)
        {
            _context = context;
        }
        public async Task<List<User>> GetAllUsers()
        {
            try
            {
                var users = await _context.Users.ToListAsync();
                return users;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
