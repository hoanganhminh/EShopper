using EShopperAPI.Models;
using EShopperAPI.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EShopperAPI.Controllers
{
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            try
            {
                var response = await _userService.GetAllUsers();
                return Ok(response);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
