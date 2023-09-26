using EShopperClient.Models;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.Text.Json;

namespace EShopperClient.Controllers
{
    public class GuestController : Controller
    {
        private readonly HttpClient client = null;

        public GuestController()
        {
            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
        }
        public IActionResult ErrorPage()
        {
            return View();
        }

        public async Task<IActionResult> Home()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return RedirectToAction("ErrorPage");
            }
        }
        public async Task<IActionResult> Product()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://localhost:7088/api/Product");
                string strData = await response.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                List<Product> listProduct = JsonSerializer.Deserialize<List<Product>>(strData, options);
                return View(listProduct);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return RedirectToAction("ErrorPage");
            }
        }
        public async Task<IActionResult> ProductDetail()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return RedirectToAction("ErrorPage");
            }
        }
        public async Task<IActionResult> Contact()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return RedirectToAction("ErrorPage");
            }
        }
        public async Task<IActionResult> Checkout()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return RedirectToAction("ErrorPage");
            }
        }
        public async Task<IActionResult> Cart()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return RedirectToAction("ErrorPage");
            }
        }
    }
}
