using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
