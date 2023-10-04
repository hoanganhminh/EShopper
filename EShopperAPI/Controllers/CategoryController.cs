using EShopperAPI.Models;
using EShopperAPI.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EShopperAPI.Controllers
{
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategorys()
        {
            try
            {
                var response = await _categoryService.GetAllCategories();
                return Ok(response);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
