using Microsoft.AspNetCore.Mvc;

namespace EShopperClient.Controllers
{
    public class GuestController : Controller
    {
        public IActionResult ErrorPage()
        {
            return View();
        }

        public async Task<IActionResult> Index()
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
