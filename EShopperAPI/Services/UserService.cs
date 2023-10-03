using EShopperAPI.Models;
using EShopperAPI.Repositories.Contracts;
using EShopperAPI.Services.Contracts;
using AutoMapper;
using EShopperAPI.Repositories;

namespace EShopperAPI.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<List<User>> GetAllUsers()
        {
            try
            {
                var users = await _userRepository.GetAllUsers();
                return users;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
