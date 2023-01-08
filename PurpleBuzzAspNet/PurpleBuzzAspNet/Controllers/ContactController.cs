using Microsoft.AspNetCore.Mvc;

namespace PurpleBuzzAspNet.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
