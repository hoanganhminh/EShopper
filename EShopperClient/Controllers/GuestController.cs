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
                HttpResponseMessage categoryResponse = await client.GetAsync(APIEndPoints.APIEndPoints.CategoryAPIEndPoints.CATEGORY_PATH);
                string categoryStrData = await categoryResponse.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                List<CategoryResponse> listCategory = JsonSerializer.Deserialize<List<CategoryResponse>>(categoryStrData, options);

                ViewModel viewModel = new ViewModel
                {
                    categoryResponses = listCategory
                };
                return View(viewModel);
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
                HttpResponseMessage productResponse = await client.GetAsync(APIEndPoints.APIEndPoints.ProductAPIEndPoints.PRODUCT_PATH);
                string productStrData = await productResponse.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                List<ProductResponse> listProduct = JsonSerializer.Deserialize<List<ProductResponse>>(productStrData, options);

                HttpResponseMessage categoryResponse = await client.GetAsync(APIEndPoints.APIEndPoints.CategoryAPIEndPoints.CATEGORY_PATH);
                string categoryStrData = await categoryResponse.Content.ReadAsStringAsync();
                List<CategoryResponse> listCategory = JsonSerializer.Deserialize<List<CategoryResponse>>(categoryStrData, options);

                ViewModel viewModel = new ViewModel
                {
                    productResponses = listProduct,
                    categoryResponses = listCategory
                };
                return View(viewModel);
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
