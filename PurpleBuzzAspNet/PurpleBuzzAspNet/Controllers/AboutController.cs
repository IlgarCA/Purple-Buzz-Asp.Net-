using Microsoft.AspNetCore.Mvc;

namespace PurpleBuzzAspNet.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
