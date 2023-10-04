using EShopperAPI.Models;
using EShopperAPI.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EShopperAPI.Controllers
{
    [Route("api/[controller]")]
    public class OrderDetailController : ControllerBase
    {
        private readonly IOrderDetailService _orderDetailService;

        public OrderDetailController(IOrderDetailService orderDetailService)
        {
            _orderDetailService = orderDetailService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOrderDetails()
        {
            try
            {
                var response = await _orderDetailService.GetAllOrderDetails();
                return Ok(response);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
