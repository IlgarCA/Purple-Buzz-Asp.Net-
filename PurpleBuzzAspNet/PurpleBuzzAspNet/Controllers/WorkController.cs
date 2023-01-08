using Microsoft.AspNetCore.Mvc;

namespace PurpleBuzzAspNet.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
