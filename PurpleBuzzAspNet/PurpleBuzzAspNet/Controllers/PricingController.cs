using Microsoft.AspNetCore.Mvc;

namespace PurpleBuzzAspNet.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
