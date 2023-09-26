using Microsoft.AspNetCore.Mvc;

namespace EShopperClient.Controllers
{
    public class GuestController : Controller
    {
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
                return View();
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
